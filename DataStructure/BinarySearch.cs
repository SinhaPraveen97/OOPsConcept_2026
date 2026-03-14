using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BinarySearch
    {
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };//,10,11,12,13,14,15,16,17,18,19,20};
        //int[] arrdevided;
        //int devidedval;
        public string GetSearchValue(int input,int [] arr,int length)
        {
            #region Confused Code :P
            //if (arrdevided == null)
            //    arrdevided = arr;
            //else
            //    arr = arrdevided;
            //devidedval = arrdevided.Length / 2;
            //if (arr[devidedval] == input)
            //    return "";
            //if(arr[devidedval] < input)
            //{
            //    arrdevided = new int[arr.Length-devidedval];
            //    int j = 0;               
            //    for (int i = devidedval; i< arr.Length; i++)
            //    {                    
            //        arrdevided[j] = arr[i];
            //        j++;
            //    }
            //    GetSearchValue(input);
            //}
            //else
            //{
            //    arrdevided = new int[arr.Length - devidedval];
            //    int j = 0;
            //    for (int i = 0; i < devidedval; i++)
            //    {                    
            //        arrdevided[j] = arr[i];
            //        j++;
            //    }
            //    GetSearchValue(input);
            //}

            #endregion
            int Low = 0;
            int High = length - 1;
            while (Low <= High)
            {
                int mid = Low + High / 2;
                if (input < arr[mid])
                    High = mid - 1;
                if (input > arr[mid])
                    Low = Low + 1;
                if (input == arr[mid])
                    return input + " input value found at position " + arr[mid];
            }
            return input + " does not found at given array!!!";
           
        }
        public static void Main()
        {
            int[] a = new int[100];
            Console.WriteLine("Enter Number of elements in the array");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter element which you want to search");
            Console.WriteLine("--------------------");
            string s3 = Console.ReadLine();
            int input = Int32.Parse(s3);
           // int input = Convert.ToInt32(Console.ReadLine());
            BinarySearch bs = new BinarySearch();
            string output = bs.GetSearchValue(input,a,x);
            Console.WriteLine(output);
            Console.ReadLine();
        }
         
    }
}
