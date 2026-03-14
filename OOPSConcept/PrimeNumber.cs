using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class PrimeNumber
    {
        public static void Main()
        {
            PrimeNumber obj = new PrimeNumber();
            bool result = obj.IsPrime(29);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            
            for(int i=2; i *i <= number;i++)
            {
                if(number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
