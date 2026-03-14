using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class AbsParentClass
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("GetDetails of AbsParentClass");
        }
    }
    //abstract class AbsClass1
    //{
    //    public abstract void getaa();
    //    public void GetData()
    //    {
    //    }
    //}
    abstract class AbsClass :AbsParentClass
    {
        public abstract override void GetDetails();
        public void GetData()
        {
            Console.WriteLine("GetData Called of Abstract class");
        }
        public abstract void GetEmployee();   

        
        //abstract void GetEmpDetails() //Error -> must be public. Virtual or abstract members cannot be private

        /*Can't declare body because its marked as abstract       
                public abstract void GetEmpDetails()
                {
                    Console.WriteLine("GetEmpDetails Called");
                }
         * */
    }
    
    class AbsChildClass :AbsClass
    {
        public override void GetDetails()
        {
            Console.WriteLine("GetDetails method called from AbsChildClass");
        }
        public override void GetEmployee()
        {
            Console.WriteLine("GetEmployee Called");
        }
        public void GetEmpDetails()
        {
            Console.WriteLine("GetEmpDetails Called");
        }
    }
    class AbstractMain
    {
        public static void Main(string [] args)
        {
            AbsChildClass CC = new AbsChildClass();
            AbsClass abs = CC;
            CC.GetData();
            abs.GetData();
            abs.GetEmployee();
            CC.GetEmpDetails();
            Console.ReadKey();

        }
    }
}
