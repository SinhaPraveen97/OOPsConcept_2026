using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConceptPrep2026
{
    public class MutableVsImmutable
    {
        public static void Main()
        {
            string a = "Hello";
            string b = "Hello";
            string c = b;
           StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" World");
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(c.GetHashCode());
            c += " World"; // Creates a new string object
            string d = "Hello World";
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            Console.WriteLine(sb.ToString()); // Hello World
            Console.WriteLine(Object.ReferenceEquals(a, b)); // True
           
        }
    }
}
