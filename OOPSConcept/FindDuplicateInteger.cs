using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class FindDuplicateInteger
    {
        public static void Main()
        {
            int[] intArr = { 1, 2, 3, 0, 3, 4, 2,3 };
            
            for (int i = 0; i < intArr.Length; i++)
            {
                int count = 1;
                int val = intArr[0];
                for (int j = i; j < intArr.Length -1; j++)
                {
                    if (intArr[i] == intArr[j + 1])
                        count = count + 1;
                }
                Console.WriteLine("\t\n " + intArr[i] + " occurs " + count + " times");
            }
            Console.ReadKey();
        }
    }
}
