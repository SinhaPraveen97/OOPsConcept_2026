using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Points To Remember
         * =============================================================================================
         *  Default scope of Class is Internal
         *  Class under namespace can only be declared as Public or Internal
         *  Class under namespace can't be declared as Private/Protected/Protected Internal
         *  Class defined under any class i.e. SubClass can be declared as private/public/internal/protected/protected internal
         *  Default scope of member of Class is Private
         *  Private Members can't be accessible outside of Class, it will be only accessible in current class
         *  
         *  ============================================================================================
         * */
namespace OOPSConcept
{    
    class FirstClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1 of First Class");
        }
        private void Method2() // this method can't be access from anywhere even from SealedClass object also in another class. same class can be access
        {
            Console.WriteLine("Method2 of First Class");
        }
        public class SubClassofFirstClass //subclass can be declared as private,public,protected,protected internal, internal
        {
            void Method1() // Members of any class is Private by default
            {
                Console.WriteLine("Method1 of SubClassofFirstClass");
            }
            public void Method2()
            {
                Console.WriteLine("Method1 of SubClassofFirstClass");
            }
        }        
    }
    class SecondClass : FirstClass
    {
        public void ChildClassMethod1()
        {
            Console.WriteLine("ChildClassMethod1 of Second Class");
        }
    }
    class ThirdClass : FirstClass.SubClassofFirstClass
    {
        public void ThirdClassMethod1()
        {
            Console.WriteLine("ThirdClassMethod1 of Third Class");
        }
        private void ThirdClassMethod2()
        {
            Console.WriteLine("ThirdClassMethod2 of Third Class");
        }
    }
    class AccessSpecifierMain
    {
        static void Main(string[] args)
        {
            FirstClass FC = new FirstClass();
            FC.Method1();
            //FC.Method2();
            FirstClass.SubClassofFirstClass obj = new FirstClass.SubClassofFirstClass();
            obj.Method2();
            //obj.Method1();
            ThirdClass TC = new ThirdClass();
            TC.Method2();
            TC.ThirdClassMethod1();
        }
    }
}
