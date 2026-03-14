using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class LambdaExpression
    {
        static void DoWork(string s)
        {
            Console.WriteLine(s);
        }
        public static void Main(string[] args)
        {
            Printer P = x =>
            {
                Console.WriteLine(x);
            };

            // Results from the Lambda Expression call.
            P("The delegate using the Lambda Expression is called.");


            // The delegate instantiation using a named method "DoWork".
            Printer p1 = new Printer(DoWork);

            // Results from the old style delegate call.
            p1("The delegate using the named method is called.");

            Console.ReadKey();

        }
    }
}
