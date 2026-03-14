using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class ParentClass
    {
        private int i = 10;
        public string name = "Praveen";
        public int x = 100;
        void ParentMethod1()
        {
            Console.WriteLine("ParentMethod1 called");
        }
        public void ParentMethod2()
        {
            Console.WriteLine("ParentMethod2 Called");
        }
        public int ParentMethod3(int i=10)
        {
            return i;
        }
        public class ParentSubClass : ParentClass
        {
            public int GetValue()
            {
                return this.i;
            }
        }
    }
    class ChildClass :ParentClass
    {
        void ChildMethod1()
        {
            Console.WriteLine("ChildMethod1 called");
        }
        public void ChildMethod2()
        {
            Console.WriteLine("ChildMethod2 Called");
        }
    }

    class superChildClass : ChildClass
    {
        public new void ChildMethod2()
        {

        }
        void SuperChildClassMethod1()
        {
            Console.WriteLine("SuperChildClassMethod1 Called");
        }
        public void SuperChildClassMethod2()
        {
            Console.WriteLine("SuperChildClassMethod2 Called");
        }
    }
    class InheritenceMain
    {
        static void Main(string[] args)
        {
            ParentClass PC = new ParentClass();
            ChildClass cc = new ChildClass();
            ParentClass pc1 = new ChildClass();
            //ChildClass CCP = new ParentClass();
            ParentClass.ParentSubClass psc = new ParentClass.ParentSubClass();

            superChildClass scc = new superChildClass();
            scc.ChildMethod2();
            
            dynamic PC1 = new ParentClass();
            var PC2 = new ParentClass();
           //// ParentClass obj = new ChildClass();
            
           // PC.ParentMethod2();
           // PC1.ParentMethod2();
           // PC1.ParentMethod3();
           // PC2.ParentMethod2();
           // PC2.ParentMethod3();         

           // ChildClass CC = new ChildClass();
           // CC.ChildMethod2();
           // CC.ParentMethod2();

           // ParentClass obj = CC;
           // obj.ParentMethod2();
           // obj = null;
           // //obj.ParentMethod2();

           // ParentClass obj1 = new ChildClass();
           // obj1.ParentMethod2();

           // var obj3 = new ParentClass.ParentSubClass();
           // Console.WriteLine(obj3.GetValue());


           // superChildClass SCC = new superChildClass();
           // SCC.SuperChildClassMethod2();
           // SCC.ChildMethod2();
           // SCC.ParentMethod2();
           
            Console.ReadLine();
            
        }
    }
}
