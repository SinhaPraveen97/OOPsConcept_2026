using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Ex_Inheritance
    {
        public int a = 10;
        public string abc = "praveen";
        private string ab;
        public void GetDetails()
        {
            Console.WriteLine("Get Details method of Ex_Inheritance class");
        }
        public virtual void getEmployee()
        {
            Console.WriteLine(" employee list");
        }
        public class SubEx_inheritanceClass
        {
            public void subclassgetdetails()
            {
                Console.WriteLine("Subclass called");
            }
        }
    }
    class Child : Ex_Inheritance
    {
        public void GetChildDetails()
        {
            Console.WriteLine("Get Details method of Child Class");
        }
        public override sealed void getEmployee()
        {
            base.getEmployee();
        }
    }
    class Ex_SuperChildclass : Child 
    {
        public void GetSuperchildclassDetails()
        {
            Console.WriteLine("GetSuperchildclassDetails called");
        }
    }
    class MyStruct
    {
        public string Name { get; set; }
    }
    public class ExecuteInheritance
    {
        private string ab;
        
        public void M1()
        {
            string b = "abc";
            if(ab!=null && ab == b)
            {

            }
        }
        public static void Main()
        {
            //string a = "$"+String.Format("{0:n}", 1234.50);
            //a = "$" + String.Format("{0:n}", 12345.33);
            //a = "$" + String.Format("{0:n}", 126345.74);
            //a = "$" + String.Format("{0:n}", 126345.03);
            //var start = DateTime.Now;
            //if (DateTime.Now.Subtract(start) < TimeSpan.FromMinutes(5))
            //{
            //}
            //// 5 Minute max wait to get file

            //MyStruct[] array = new MyStruct[] { new MyStruct { Name = "123" }, new MyStruct { Name = "2" } };
            //List<string> list1 = new List<string> { "","","",""};
            //foreach(var obj in array)
            //{
            //    obj.Name = obj.Name.Replace("1", "");
            //}
            ////List<int> list2 = new List<int> { 12, 5, 7, 9, 1 };
            ////List<int> ulist = list1.Union(list2).ToList();
            ////var list = list1.Concat(list2).ToList();

            ////var ticketsFaOrNot = reverseOrderFaTicketsToUpdate.concat(normalOrderFheTicketsToUpdate).ToList();



            ////Ex_Inheritance obj = new Ex_Inheritance();
            ////obj.GetDetails();
            ////Child obj1 = new Child();
            ////obj1.GetChildDetails();
            ////obj1.GetDetails();
            ////obj1.getEmployee();
            ////Ex_SuperChildclass Superchild = new Ex_SuperChildclass();
            ////Superchild.GetDetails();
            ////Superchild.getEmployee();
            ////Superchild.GetSuperchildclassDetails();
            ////Superchild.GetChildDetails();
            ////Child cc = new Ex_SuperChildclass();
            ////Ex_Inheritance.SubEx_inheritanceClass ObjSubClass = new Ex_Inheritance.SubEx_inheritanceClass();
            ////ObjSubClass.subclassgetdetails();
            //string data = "////29APR93/F//BORGHESI/GEORGIA";
            ////string regex = "^[0-9]{2}[A-Za-z]{3}[0-9]{2}$";
            ////string result = string.Empty;
            ////string[] splitVal = data.Split('/');
            ////foreach(var sp in splitVal)
            ////{
            ////    MatchCollection coll = Regex.Matches(sp, regex);
            ////    if (coll.Count > 0)
            ////    {
            ////        result = coll[0].Groups[0].Value;
            ////        if (!string.IsNullOrEmpty(result))
            ////            return;
            ////    }
            ////}

            ////string regex = "^[0-9]{2}[A-Za-z]{3}[0-9]{2}$";
            //string regex = "([0-9]{2})([A-Za-z]{3})([0-9]{2})";
            //string result = string.Empty;
            //string m = string.Empty;
            //int Date;
            //int year;
            //DateTime DOB;

            ////Pax_DOB = ssrDoc.FreeText.Split('/')[4]; 
            //string[] splitVal = data.Split('/');
            //foreach (var sp in splitVal)
            //{
            //    MatchCollection coll = Regex.Matches(sp, regex);
            //    if (coll.Count > 0)
            //    {
            //        result = coll[0].Groups[0].Value;
            //        if (!string.IsNullOrEmpty(result))
            //        {
            //            Date = Convert.ToInt32(result.Substring(0, 2));
            //            m = result.Substring(2, 3);
            //            year = Convert.ToInt32(result.Substring(5, 2));
            //            int fourDigitYear = CultureInfo.CurrentCulture.Calendar.ToFourDigitYear(year);
            //            int month = DateTime.ParseExact(m, "MMM", CultureInfo.InvariantCulture).Month;
            //            DOB = new DateTime(fourDigitYear, month, Date);
            //        }
            //    }
            //}              


            //    Console.WriteLine(result);


            //// foreach(string myString in data) {
            ////MatchCollection coll = Regex.Matches(data, regex);
            ////String result = coll[0].Groups[0].Value;
            //// Console.WriteLine(result);
            ////if(Regex.IsMatch(myString, "^[A-Za-z]{2}[0-9]{2}$")) {
            ////if(Regex.IsMatch(myString, "^[0-9]{2}[A-Za-z]{3}[0-9]{2}$")) {
            //// Console.WriteLine("{0} matches", myString);
            //// } else {
            ////   Console.WriteLine("{0} doesn't match", myString);
            ////}
            ////}



            ExecuteInheritance obj = new ExecuteInheritance();
            obj.M1();
            string text = System.IO.File.ReadAllText(@"C:\Source\Praveen.txt");
            string text1 = System.IO.File.ReadAllText(@"C:\\Source\Praveen.txt");
            string[] arr1 = { "Praveen", "Praveen", "bittu", "bittu", "amit", "vishal" };
            var arr = new List<string>(arr1);
            for(int i=0; i< arr.Count;i++)
            {
                for(int j=i+1; j<arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr.RemoveAt(j);
                    }
                }
            }

                    Console.ReadLine();
        }


    }
}


////Access Specifiers :-
//--==========================
//public - accessed from anywhere
//private - only accessible within class
//internal - accessible within projects
//protected -- same class and child class
//protected internal - 
//single inheritance
// multiple inhertance
