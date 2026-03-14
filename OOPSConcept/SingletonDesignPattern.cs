using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class SingletonDesignPattern
    {
        protected static SingletonDesignPattern instance;
        private SingletonDesignPattern()
        {

        }     
        public static void PrintValue(string s)
        {
            Console.WriteLine(s);
        }
        public static SingletonDesignPattern GetObject()
        {
            if (instance == null)
                instance = new SingletonDesignPattern();
            //instance.GetHashCode();
            return instance;
        }
       
    }
    class SingletonMain
    {
        public static void Main(string[] args)
        {
            //SingletonDesignPattern obj = new SingletonDesignPattern();
            SingletonDesignPattern.GetObject();
            SingletonDesignPattern.PrintValue("abc");
            SingletonDesignPattern.GetObject();
            Console.ReadLine();
        }
    }
}
