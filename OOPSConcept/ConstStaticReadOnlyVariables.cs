using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class ConstStaticReadOnlyVariables
    {
        public const int I_CONST_VALUE = 1;
        public readonly int I_RO_VALUE;
        public static readonly string State;
        static int I_ST_Value;

        static ConstStaticReadOnlyVariables()
        {
            Console.WriteLine(State);
            State = "RRRR";
            I_ST_Value=4;
            Console.WriteLine(I_CONST_VALUE + State + I_ST_Value);
            
        }

         public ConstStaticReadOnlyVariables(int x)
        {
            I_RO_VALUE = x;
            

           // I_RO_VALUE = 3;
            
            Console.WriteLine(I_RO_VALUE);
        }
         public void Method()
         {
             //I_RO_VALUE = 2;
             //I_CONST_VALUE = 5;
             //State = "GGG";
             I_ST_Value = 4;
             Console.WriteLine(I_ST_Value);
         }

        public static void Main(string [] args)
        {
            
            //I_CONST_VALUE = 11; // cant change constant value
            
            I_ST_Value = 12;
            ConstStaticReadOnlyVariables c = new ConstStaticReadOnlyVariables(6);
            c.Method();
            
            Console.WriteLine(I_CONST_VALUE + "" + I_ST_Value + State);
            Console.ReadKey();
     //       ConstStaticReadOnlyVariables.I_
            //Object
        }
    }
}
