using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* 
     
 ==================================
  Points To Remember
 ==================================
     * Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.
     * Extension methods are a special kind of static method.
     * Extension methods are additional custom methods which were originally not included with the class.
     * Extension methods can be added to custom, .NET Framework or third party classes, structs or interfaces.
     * The first parameter of the extension method must be of the type for which the extension method is applibable, preceded by the this keyword
     * Extension methods can be used anywhere in the application by including the namespace of the extension method.    
     * 
     * An extension method will never be called if it has the same signature as a method defined in the type
     * 
     *  Ex :- //never called with integer because same method is already present with integer type.
     *       public static bool Equals(this int i,int value)
             {
                 return i == value;
             }
     *      
     *      //here i.Equals(10) will never called user defined extension method because same signature as this is already defined in the type.
     *      bool flag = i.Equals(10);
     */
    public static class IntExtension
    {
        public static bool IsGreaterThan(this int i,int value)
        {
            return i > value;
        }
        public static bool Equals(this int i,int value)
        {
            return i == value;
        }
    }
    class ExtensionMain
    {
        public static void Main(string [] args)
        {
            int i = 10;
           
            bool flag = i.Equals(10);
            bool flag1 = i.IsGreaterThan(100);
            Console.WriteLine(i + " > 100 = " + flag);
            Console.ReadKey();
               
        }
    }
}
