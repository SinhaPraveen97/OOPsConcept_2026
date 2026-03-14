using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{

    /* Points to Remember
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/
     * A delegate is a type that represents references to methods with a particular parameter list and return type
     * when we instantiate a delegate then we can associate its instance with any method with a compatible signature and return type.
     * 
     * In the context of method overloading, the signature of a method does not include the return value. 
     * But in the context of delegates, the signature does include the return value. In other words, a method must have the same return type as the delegate.
     * Ex:- 
     *         //Declares a delegate named Del which can encapsulate a method that takes a string as an argument and returns void.
     *          public delegate void Del(string message);   
     *          
     * // Create a method for a delegate.
            public static void DelegateMethod(string message)
            {
                System.Console.WriteLine(message);
            }
     * 
     * // Instantiate the delegate.
            Del handler = DelegateMethod;
            
            // Call the delegate.
            handler("Hello World");
     * 
     * Used for defining callback methods.
     * Delegates can be chained together; for example, multiple methods can be called on a single event.
     */
    
    
    public delegate int NumberChange(int x);
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int x)
        {
            num += x;
            return num;
        }
        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        static void Main(string [] args)
        {
            //Create Delegate instance
            NumberChange N;
            NumberChange N1 = new NumberChange(AddNum);
            NumberChange N2 = new NumberChange(MultNum);
            //calling the methods using the delegate objects
            //N1(25);
            //Console.WriteLine("Value of Num: {0}", getNum());
            //N2(10);
            //Console.WriteLine("Value of Num: {0}", getNum());

            //MultiCast Delegates
            N = N1;
            N += N2;
            N(10);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}

