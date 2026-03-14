using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class ReverseAString
    {
        public static void Main()
        {
            ReverseAString obj = new ReverseAString();
            string output = obj.ReversedString("hello master");
            Console.WriteLine(output);
            Console.ReadKey();
        }

        public string ReversedString(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] arr = s.ToCharArray();
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            return new string(arr);
        }
    }
}
