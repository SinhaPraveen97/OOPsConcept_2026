using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class ReverseString
    {

        public static void Main()
        {
            string input = string.Empty;
            string reverseString = string.Empty;
            int length;  
            Console.WriteLine("Please input any string");
            input = Convert.ToString(Console.ReadLine());
            //length = input.Length - 1;
            //while (length >= 0)
            //{
            //    reverseString = reverseString + input[length];
            //    length--;
            //}
            //Console.WriteLine(reverseString);
            string[] strArr = input.Split(' ');
            for (int i = 0; i < strArr.Length; i++ )
            {
                if (!string.IsNullOrEmpty(reverseString))
                    reverseString += " ";
                length = strArr[i].Length - 1;
                while(length >= 0)
                {
                    reverseString = reverseString + strArr[i][length];
                    length--;
                }
            }
            Console.WriteLine(reverseString);
            Console.ReadLine();
        }
    }
}
