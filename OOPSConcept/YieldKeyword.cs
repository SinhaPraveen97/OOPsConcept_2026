using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class YieldKeyword
    {
        static List<int> list = new List<int>();
        static List<int> iList = new List<int>();
        static void FillValues()
        {
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
        }
        static IEnumerable<int> FilterWithoutYield()
        {

            foreach (int items in list)
            {
                if (items > 3)
                    iList.Add(items);
            }
            return iList;
        }
        static int items = 0;
        static IEnumerable<int> FilterWithYield()
        {
            foreach (int items in list)
            {
                if (items > 3)
                    yield return items;
            }

        }
        public static void Main(string [] args)
        {
            FillValues();
            FilterWithoutYield();
            FilterWithYield();
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            foreach (int item in iList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
