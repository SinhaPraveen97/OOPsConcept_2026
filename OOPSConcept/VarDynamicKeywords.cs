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
     * var keyword can never be used as class members directly i.e. var is not allowed at class scope. It will throw below compilation error.
     *      "The Contextual keyword var may only appear within a local variable declaration"
     *      
     * If you really don't know the type of object your instance variable will hold, use object, not var. 
     * var doesn't mean "i don't know", it means "infer the type for me" - this is why it can never be used on class members.
     * 
     * var must be initialized at the time of declaration.
     * dynamic can be initialized or cannot be.
     * var keyword will resolve at compile time only. so we cannot change var type value to any other type after initialization.
     *      var i = 10;
     *      i = "name"; // not valid
     *      
     * dynamic keyword will resolve at runtime only. we can change dynamic type value to any other type also.
     *      dynamic val = "abc";
     *      val = 12.44;// valid
     *      var = true;// valid
     */
    class VarDynamicKeywords
    {
        //var i = 10; // never be used. gives an compilation error i.e. "The Contextual keyword var may only appear within a local variable declaration"
        dynamic name = "Praveen";

        public dynamic abc()
        {
            return 1;

        }
        public void GetDetails()
        {
            var i = 10; //valid
            //var x;// Not valid "Implicitly typed local variable must be initialized"
            dynamic val; // Valid
            val = 11.50;
            Console.WriteLine("Value of i is " + i + " and Value of name is " + name + " and value of val is "+val);
           //i = "praveen"; // Not valid "Cannot implicitly convert type 'string' to 'int'" as we have already initialized i with value 10. so now it will treat i as integer variable.
            val = true;
            name = 10;
            Console.WriteLine("Value of i is " + i + " and Value of name is " + name + " and value of val is " + val);
        }
    }
    class VarDynamicMain
    {
        public static void Main(string [] args)
        {
            VarDynamicKeywords obj = new VarDynamicKeywords();
            obj.GetDetails();
            Console.ReadKey();
        }
    }
}
