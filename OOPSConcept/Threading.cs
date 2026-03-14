using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Threading
    {
        public void TestThread()
        {
            Console.WriteLine("Test Thread");
        }
        public static void Main()
        {
            Threading th = new Threading();
            th.TestThread();
            Console.ReadLine();
        }
    }
}
