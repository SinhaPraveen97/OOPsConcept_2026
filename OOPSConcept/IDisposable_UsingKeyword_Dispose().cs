using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class IDisposable_UsingKeyword_Dispose__ : IDisposable
    {
        public void TestDispose()
        {
            Console.WriteLine("Test Dispose");
        }
        //must implement Dispose method if IDisposable interface is inherited
        //calls Dispose method automatically once using block executed and kills object of using block
        public void Dispose()
        {

        }
        public static void Main()
        {
            //IDisposable interface must be inherited to use "using" block
            //using block gives an compilation error if not you have not inherited IDisposable interface
            using(IDisposable_UsingKeyword_Dispose__ obj = new IDisposable_UsingKeyword_Dispose__())
            {
                obj.TestDispose();
                // Created object obj for this class
                //Before calling Dispose method obj contains obj = {OOPSConcept.IDisposable_UsingKeyword_Dispose__}
                //after execution of using block it will call Dispose method automatically
                //after dispose obj is no longer exist
            }           
            IDisposable_UsingKeyword_Dispose__ obj1 = new IDisposable_UsingKeyword_Dispose__();
            obj1.TestDispose();
            Console.ReadLine();            
        }

    }
}

