using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class LinearSearch
    {
        public string GetSearchValue(int input)
        {
            int[] arr = { 12, 33, 56, 795,44,6,7,8,9,33,45,65,23,78 };
            for(int i=0; i<arr.Length;i++)
            {
                if (input == arr[i])
                    return input +" found at position "+ (i+1);
            }
            return input + " does not found at given collection";
            
        }

        public static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            LinearSearch ls = new LinearSearch();
            string output = ls.GetSearchValue(input);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
