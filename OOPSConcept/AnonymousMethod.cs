using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* Points To Remember
     * In versions of C# before 2.0, the only way to declare a delegate was to use named methods.
     * C# 2.0 introduced anonymous methods and in C# 3.0 and later, 
     * lambda expressions supersede anonymous methods as the preferred way to write inline code.
     * An anonymous function is an "inline" statement or expression that can be used wherever a delegate type is expected.
     * By using anonymous methods, you reduce the coding overhead in instantiating delegates because you do not have to create a separate method.
     */

    //Declare a delegate
    delegate void Printer(string s);
    class AnonymousMethod
    {
        static void DoWork(string s)
        {
            Console.WriteLine(s);
        }

        static void DoPrint(string k)
        {
            Console.WriteLine(k + "sss");
        }
        public static void Main(string [] args)
        {
            // Instantiate the delegate type using an anonymous method.
            Printer p = delegate(string j)
            {
                Console.WriteLine(j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");


            // The delegate instantiation using a named method "DoWork".
            Printer p1 = new Printer(DoWork);

            // Results from the old style delegate call.
            p1("The delegate using the named method is called.");

            Printer p2 = new Printer(DoPrint);
            p2("Hello");

            Printer p3 = delegate(string t)
            {
                Console.WriteLine("the deligate using the anonymus method is called2" + t);
            };
            p3("SSSS");
            

            Console.ReadKey();
            
        }
    }
}
