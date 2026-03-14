using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* Points to Remember
      
       1. String is immutable
       2. String Builder is mutable
       3. Immutable -> When we implement modifications to the existing String object within memory it will create a new object.
       4. Mutable -> When we implement modifications to the existing StringBuilder object will not create new copy of object instead of that it will modify the existing object.
     */
    class MutableVsImmutable
    {
        public static void Main(string [] args)
        {
            //we will create string object s1 and will assign some value . after we will print address of string object s1
            //now we will concatenate some more strings to s1 string object . and we will print address of string object s1
            //Now observe address of s1 objects.. it will be different address after concatenate.

            string s1 = "Hyderabad";
            Console.WriteLine("Value of String S1 = "+ s1);
            Console.WriteLine("\n Address of String S1 = " + s1.GetHashCode());        // Prints Address of S1 
            s1 = s1 + " Cyberabad";        // Appending some string to existing s1 object. now it will create another object for concatenate
            Console.WriteLine("\n Value of String S1 after modification  = " + s1);
            Console.WriteLine("\n Address of String S1 is after modification = " + s1.GetHashCode());        // Prints address of S1           
            


            // we will create stringbuilder object s2 and will assign some value . after we will print address of stringbuilder object s2
            // now we will append some more strings to s2 stringbuilder object . and we will print address of stringbuilder object s2
            //Now observe address of s2 objects.. it will be same address after concatenate also.
            StringBuilder s2 = new StringBuilder("Hyderabad");
            Console.WriteLine("\n Value of StringBuilder S2 = " + s2);
            Console.WriteLine("\n Address of StringBuilder S2 = " + s2.GetHashCode());
            s2.Append(" Cyberabad");
            Console.WriteLine("\n Value of StringBuilder S2 after modification  = " + s2);
            Console.WriteLine("\n Address of StringBuilder S2 is after modification = " + s2.GetHashCode());
            Console.ReadLine();            
        }
    }
}
