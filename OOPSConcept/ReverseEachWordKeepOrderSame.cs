using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    //input- "I love coding"
    //output - "I evol gnidoc"
    internal class ReverseEachWordKeepOrderSame
    {
        public static void Main()
        {
            ReverseEachWordKeepOrderSame obj = new ReverseEachWordKeepOrderSame();
            string output = obj.ReverseEachWord("I love coding");
            Console.WriteLine(output);
            Console.ReadKey();
        }

        string ReverseEachWord(string input)
        {
            char[] arr = input.ToCharArray();
            int start = 0;

            for (int i = 0; i <= arr.Length; i++)
            {
                // End of word or end of string
                if (i == arr.Length || arr[i] == ' ')
                {
                    Reverse(arr, start, i - 1);
                    start = i + 1;
                }
            }

            return new string(arr);
        }

        void Reverse(char[] arr, int left, int right)
        {
            while (left < right)
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
        }

    }
}
