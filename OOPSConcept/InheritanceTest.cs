using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class InheritanceTest
    {
        public void GetMethod()
        {
            Console.WriteLine();
        }
    }
    class childClassTest : InheritanceTest
    {
        public void GetMethod1()
        {
            Console.WriteLine();
        }
    }
    class InheritanceMainMethod
    {
        public static void Main()
        {
            InheritanceTest obj = new childClassTest();
            obj.GetMethod();
        }
    }
}
