using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class IntParseVsConvertInt32
    {
        public static void Main(string [] args)
        {
            int i = 10;
            double x = 10.00;
            string val = null;
            //string a;
            string value = "10";
            i = int.Parse(value);
            Console.WriteLine(i);
            //i = int.Parse(x);//Error - Int.Parse will accept only string. it will only convert string to integer.
            i = Convert.ToInt32(x); // Convert.ToInt32 accepts all datatypes as input. it has 19 overloaded method to accept all data types.
            Console.WriteLine(x);
            //i = int.Parse(val); // throws Run time error System.ArgumentNullException because int.Parse cannot convert null value to integer
            //Console.WriteLine(i);
            i = Convert.ToInt32(val); // Success. If string is null then Convert.ToInt32 will convert to default value of integer
            Console.WriteLine(i);
            value = Convert.ToString(val); // Success. If string is null then Convert.ToString will convert to default value of string i.e. null    
            Console.WriteLine(value);
            value = val.ToString(); // throws run time error system.NullReferenceException because cannot convert null value to string.
            Console.WriteLine(value);


            string s1 = "Hydera"; 
            Console.WriteLine(s1.GetHashCode());
            s1 = s1 + "bad";
            Console.WriteLine(s1.GetHashCode()); 
            Console.WriteLine(s1);
            StringBuilder s2 = new StringBuilder("Hydera"); 
            Console.WriteLine(s2.GetHashCode()); 
            s2.Append("Bad"); 
            Console.WriteLine(s2.GetHashCode());
            Console.ReadLine();
            
            
        }
    }
}
