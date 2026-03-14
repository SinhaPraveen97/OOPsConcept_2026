using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{

    /* Points to Remember
     * Interface members i.e. methods can't have any access modifiers
     * Interface can't contain fields
     * A Class can inherit n number of interface
     * A Class can inherit only one class and n number of interface .. Class should inherit class first then interface
     *      EX :- 
     *          
     * 
     */
    interface InterfaceClass1
    {
        void GetData();

        //public void GetData(); // Can't have any access modifiers 
        //int x = 10; // Can't contain fields
    }

    interface InterfaceClass3 : InterfaceClass1
    {
        new void GetData();
    }
    interface InterfaceClass2 
    {
         void GetData();
    }

    class BaseClass1 : InterfaceClass2,InterfaceClass1
    {
        void InterfaceClass1.GetData()
        {
            Console.WriteLine("");
        }
        void InterfaceClass2.GetData()
        {
            Console.WriteLine("");
        }
    }
    class BaseClass2 : BaseClass1,InterfaceClass1
    {
        void InterfaceClass1.GetData()
        {
            Console.WriteLine("");
        }       
    }
    class ImplementInterface : BaseClass1,InterfaceClass1,InterfaceClass2
    {
        void InterfaceClass1.GetData()
        {
            Console.WriteLine("");
        }
        void InterfaceClass2.GetData()
        {
            Console.WriteLine("");
        }
    }
    

    class InterfaceMain
    {
        public static void Main(string [] args)
        {
            Console.ReadKey();
        }
    }
     
}
