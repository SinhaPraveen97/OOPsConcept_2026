using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class USConsultant
    {


        /// <summary>
        /// Write a successful result file
        /// </summary>
        /// <param name="correlationId"></param>
        /// <param name="inputFile"></param>
        /// <param name="results"></param>
        /// <param name="resultsFilePath"></param>
        private void WriteSuccessResult(Guid correlationId, FileInfo inputFile, IList<VoucherCreateResult> results, out string resultsFilePath)
        {
            // Get the result directory path
            var resultPath = GetResultDir(ProcessKey);

            // Get the successful results file name
            var file = PREFIX_SUCCESS + GetResultFileName(correlationId, inputFile);

            // Create the new file if necessary, otherwise append to the file
            var fileInfo = new FileInfo(resultPath + file);
            resultsFilePath = fileInfo.FullName;

            AmadeusEvents.Log.Information("Writing error file to: " + resultsFilePath);

            StreamWriter writer;
            if (!fileInfo.Exists)
            {
                var stream = fileInfo.Create();
                writer = new StreamWriter(stream);
            }
            else
            {
                writer = File.AppendText(fileInfo.FullName);
            }

            // Add the results to the result file
            AddResultLines(writer, results);
            // commented extra Reference info from result file.
            //writer.WriteLine("Reference: " + correlationId.ToString());
            AmadeusEvents.Log.Information("Reference: " + correlationId.ToString());
            AmadeusEvents.Log.Information("resultsFilePath: " + resultsFilePath);

            // Close the file
            writer.Close();
        }






        /// <summary>
        /// Works the queue item.  We should never return false. If we fail with an exception, the queue item is safe to be worked again
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="queueItem"></param>
        /// <param name="bodyType"></param>
        /// <param name="correlationId"></param>
        /// <param name="queueItemName"></param>
        /// <param name="workQueueItemResponse"></param>
        /// <returns>a boolean</returns>
        public bool ProcessQueueItem(string processName, object queueItem, string bodyType, Guid correlationId, string queueItemName, WorkQueueItemResponse workQueueItemResponse)
        {
            // Initialize the logging
            AmadeusEvents.Log.StartRobotProcess(GetProcessData().ProcessName, "", Carrier, Family, 1, correlationId);
            AmadeusEvents.Log.EnableAuditing();

            try
            {
                // Get the path to the temporary file created by VoucherCreateRobotBatch
                var path = (string)queueItem;
                var fileInfo = new FileInfo(path);
                var defaultVoucherEmail = ConfigurationManager.AppSettings["VoucherCreationDefaultEmail"];
                var successVoucherEmail = ConfigurationManager.AppSettings["VoucherCreationSuccessEmail"];

                // If this file exists, do some work
                if (fileInfo.Exists)
                {
                    // Create a list of records and a string to hold the results file path
                    IList<CreateVoucherRecord> records;
                    string resultsFilePath;
                    bool isNewFile;
                    List<CreateVoucherRecord> validatedRecords = new List<CreateVoucherRecord>();

                    try
                    {
                        // Determine if it is the OLD CSV file or the NEW CSV file.
                        // Read all the text in the file
                        var fileText = File.ReadAllText(fileInfo.FullName);

                        // Determine if it is the OLD CSV file or the NEW CSV file.
                        isNewFile = CreateVoucherRecord.IsNewCsvFile(fileText);
                        AmadeusEvents.Log.Information($"{GetProcessData().ProcessName}_Batch. NewCsvFileProcess - IsNewCsvFile: {isNewFile}");

                        if (isNewFile)
                        {
                            // Get the records from the CSV file
                            records = CreateVoucherRecord.ReadNewCsv(fileText, "VoucherData").ToList();

                            // Validate the records
                            // We reject only the non-valid record.
                            var listRecordFailure = CreateVoucherRecord.ValidateRecordsNewFile(records, out validatedRecords);

                            if (records.Count < 1)
                            {
                                // Write an error to the results file, and signal to mark this queue item as worked
                                WriteErrorResult(correlationId, fileInfo, "No valid rows in temp file, please check format of file", out resultsFilePath);
                                AmadeusEvents.Log.Information($"{GetProcessData().ProcessName}_Batch. NewCsvFileProcess - No valid rows in temp file, please check format of file");
                                return true;
                            }
                        }
                        else
                        {
                            // Get the records from the CSV file, to be sent with the email
                            records = CreateVoucherRecord.ReadCsv(File.ReadAllText(fileInfo.FullName), "VoucherData").ToList();
                            if (records.Count < 1)
                            {
                                // Write an error to the results file, and signal to mark this queue item as worked
                                WriteErrorResult(correlationId, fileInfo, "No valid rows in temp file, please check format of file", out resultsFilePath);
                                return true;
                            }
                        }
                    }
                    catch (Exception exception)
                    {
                        // Something bad happened. Write an error to the results file and the audit log, and signal to mark this queue item as worked
                        WriteErrorResult(correlationId, fileInfo, "Unknown exception occured parsing temp file, please check format of file", out resultsFilePath);
                        AmadeusEvents.Log.Exception(exception);
                        return true;
                    }

                    // Create a communication strategy and a domain model
                    var strategy = new QantasCommunicationStrategy(new StateTableService(), GetProcessData(), BusinessDataRepository);
                    var domainModel = new QantasDomainKnowledge(strategy);

                    // Set a start time, end time, and incomplete flag, and create a list of voucher results
                    var startTime = DateTime.Now;
                    var endTime = startTime.AddMinutes(_minutesToWait); // i think this is reasonable
                    var isComplete = false;
                    IList<VoucherCreateResult> results = new List<VoucherCreateResult>();

                    // Wait until the vouchers are created and ticketed, or time out
                    while (!isComplete && DateTime.Now < endTime)
                    {
                        // Check the results from the database to determine if the records associated
                        // with this correlation ID have a ticket number, issue date, and queue.
                        // If so, this job is complete, otherwise keep waiting for processing to finish or time out
                        isComplete = domainModel.IsVoucherCreationComplete(correlationId, out results);

                        if (!isComplete)
                        {
                            AmadeusEvents.Log.Information("Process not complete waiting 5 seconds");
                            Thread.Sleep(5000);
                        }
                        // Do nothing (file doesnt exist yet)
                    }

                    // If we ever completed, check fo errors.  If there were errors, write them to the results
                    // file, otherwise write a successful result to the results file, and email it
                    if (isComplete)
                    {
                        AmadeusEvents.Log.Information("Process not complete.");
                        var hasError = results.Any(result => result.HasError.HasValue && result.HasError.Value);
                        if (hasError)
                        {
                            AmadeusEvents.Log.Information("Process has error writing error result");
                            WriteErrorResult(correlationId, fileInfo, "Completed processing with errors", results, out resultsFilePath);
                        }
                        else
                        {
                            AmadeusEvents.Log.Information("Process has success writing success result");
                            WriteSuccessResult(correlationId, fileInfo, results, out resultsFilePath);
                        }

                        if (isNewFile)
                        {
                            var hasFailures = HasResultFailures(fileInfo, validatedRecords, results, out var errorMessage);

                            if (hasFailures)
                            {
                                foreach (var record in validatedRecords)
                                {
                                    var email = string.IsNullOrEmpty(record.RequestorEmail) ? defaultVoucherEmail : $"{record.RequestorEmail};{defaultVoucherEmail}";
                                    _email.SendFailureEmail(errorMessage, email, fileInfo.Name, resultsFilePath);
                                }
                                AmadeusEvents.Log.Information($"{GetProcessData().ProcessName}_Batch. NewCsvFileProcess - Results have failures: {errorMessage}");
                            }
                            else
                            {
                                foreach (var record in validatedRecords)
                                {
                                    var email = string.IsNullOrEmpty(record.RequestorEmail) ? successVoucherEmail : $"{record.RequestorEmail};{successVoucherEmail}";
                                    _email.SendSuccessEmail(resultsFilePath, email);
                                    AmadeusEvents.Log.Information($"{GetProcessData().ProcessName}_Batch. NewCsvFileProcess - Results successful");
                                }
                            }
                        }
                        else
                        {
                            _email.Send(fileInfo, records, results, resultsFilePath, Carrier, Family);
                        }
                    }
                    else
                    {
                        AmadeusEvents.Log.Information("Process never complete, writing error result");
                        // If we never completed processing and timed out, write an error to the results file, and email it
                        WriteErrorResult(correlationId, fileInfo, "Timeout occurred waiting for all results", results, out resultsFilePath);

                        if (isNewFile)
                        {
                            _email.SendFailureEmail("Timeout occurred waiting for all results", defaultVoucherEmail, fileInfo.Name, resultsFilePath);
                            AmadeusEvents.Log.Information($"{GetProcessData().ProcessName}_Batch. NewCsvFileProcess - Timeout occurred waiting for all results");
                        }
                        else
                        {
                            _email.Send(fileInfo, records, results, resultsFilePath, Carrier, Family, "Timeout failure in Voucher Create");
                        }
                    }
                }
                else
                {
                    // Log that the input file missing
                    AmadeusEvents.Log.Information("Temp file is missing. Unknown state. Has work been done?");
                }

                // Signal to mark the queue item worked
                return true;
            }
            catch (Exception exception)
            {
                AmadeusEvents.Log.Exception(exception);
                return false;
            }
        }
    }
}
