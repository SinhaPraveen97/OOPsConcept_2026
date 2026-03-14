using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Points To Remember
         * =============================================================================================
         *  Static Class can contain only static member in it
         *  Cannot declare instance member in static Class
         *  Cannot Create instance/Object of Static Class
         *  Member of static Class cannot be accessed using instance of static class, can be accessed by class name directly
         *  Static Methods: These methods can implement operations on static fields and properties only; and can‘t access the non-static members.
         *  Static Constructors : Static constructor is used to initialize the static data members, whereas the normal constructor (non-static constructor) is used to initialize the non-static data members.
         *  By default Static Class is sealed class and therefore cannot be inherited.
         *  ============================================================================================
*/

namespace OOPSConcept
{
   public static class StaticClass
    {
       //int i = 10; //Can't declare instance member in static class
       //Cannot create instance of static Class

       static StaticClass()
       {
           Console.WriteLine("static constructor called");
       }      
       static string Name = "praveen";
       public static void Method1()
       {
           Console.WriteLine("Method1 of Static Class Called");
       }
    }

   class StaticClassMain
   {
       static void Main(string[] args)
       {
           //StaticClass SC = new StaticClass();
           //SC.Method1()
           StaticClass.Method1(); 
       }
   }
}
