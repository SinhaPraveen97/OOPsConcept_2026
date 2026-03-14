using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* Points to Remember
     * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
     * 
         1. Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. 
         2. When the CLR boxes a value type, it wraps the value inside a System.Object and stores it on the managed heap.
         3. Unboxing extracts the value type from the object.
         4. Boxing is implicit; unboxing is explicit.
                 int i = 123;
                // The following line boxes i.
                    object o = i;  
                    i = (int)o;  // unboxing
         5. //Boxing always maintains a seperate copy
         6. Checking the object instance to make sure that it is a boxed value of the given value type.
         7. Copying the value from the instance into the value-type variable.
                int i = 123;      // a value type
                object o = i;     // boxing
                int j = (int)o;   // unboxing
         8. For the unboxing of value types to succeed at run time, 
                the item being unboxed must be a reference to an object that was previously created by boxing an instance of that value type.
     
         9. Unboxing will be done to same datatype from which its boxed to ReferenceType.
                Ex: -
                     int i = 123;
                     object o = i;  // implicit boxing
                     int j = (short)o;  // attempt to unbox // Error//Specified cast is not valid. Error: Incorrect unboxing.
                     int j = (int)o;  // attempt to unbox // Success
    
     
     
     */
    class BoxingAndUnBoxing
    {
        
        public void GetDetails()
        { 
            List<object> mixedList = new List<object>();
            mixedList.Add("String value");
            for(int j= 0; j <5;j++)
            {
                mixedList.Add(j);
            }
            mixedList.Add("another String value");
            for(int j=0; j<5 ; j++)
            {
                mixedList.Add(j);
            }

            //Now display the item presents in list
            //using var, so that the compiler assigns its type            
            foreach(var item in mixedList)
            {
                // Keep the mouse pointer over item to verify that the elements
                // of mixedList are objects.
                Console.WriteLine(item);
            }
            var sum = 0;
            for (var j = 1; j<5; j++)
            {
                //sum += mixedList[j] * mixedList[j];// Operator cannot be applied to operands of type 'object' and 'object'
                
                sum += (int)mixedList[j] * (int)mixedList[j]; // Unboxing
            }
            Console.WriteLine(sum);
        }
    }
    class BoxingUnBoxingMain
    {
        public static void Main(string [] args)
        {
            //Boxing always maintains a seperate copy
                //EX: - 
            int i = 100;
            object o = i;
            i = 150;
            Console.WriteLine(i+" "+ o);

            BoxingAndUnBoxing obj = new BoxingAndUnBoxing();
            obj.GetDetails();
            Console.ReadKey();
        }
    }
}
