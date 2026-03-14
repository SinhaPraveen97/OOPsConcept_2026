using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
   public abstract class AbstractTest
    {
        void GetDetails()
        {
            Console.WriteLine("GetDetails");
        }
        public abstract void Get2();
        public abstract void Get3();
       public AbstractTest()
        {
            Console.WriteLine("Constructor");
        }
        AbstractTest(int x)
        {

        }
       
    }
    public abstract class Class1 : AbstractTest
    {
        public override void Get2()
        {
            throw new NotImplementedException();
        }
        public abstract override void Get3();

    }
}
