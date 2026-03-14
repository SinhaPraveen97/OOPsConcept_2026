using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Points To Remember
/*
 ==================================
  Points To Remember
 ==================================
  *     ====================================================================================================================================================================
         *  If there is no any constructor defined in class then default constructor will be called internally
         *  Within a class you can create only one static constructor. 
         *  Static Constructor will be called first once object created.
         *  Static Constructor will be called only once
         *  A static constructor does not take access modifiers or have parameters or any return type
         *  A static constructor cannot be called directly
         *  A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.
         *  If any class is having only private constructor then its not possible to inherit that class and not possible to create object also.
         *  If any class is having public constructor and private constructor both then its possible to create object and can be inherit also.
         
         * if child class object created then below sequence will execute i.e. ChildClass obj = new ChildClass();
                 1. Static Constructor will be called of child class
                 2. Static constructor will be called of parent class
                 3. Default constructor will be called of parent class
                 4. Default Constructor will be called of child class
 
         * if child class object created with parameter then below sequence will execute i.e. ChildClass obj = new ChildClass(10);
                 1. Static Constructor will be called of child class
                 2. Static constructor will be called of parent class
                 3. Default constructor will be called of parent class
                 4. parameterized Constructor will be called of child class
 * 
          * Usage of "base" keyword with child class constructor i.e. Calling Parent Class constructor first explicitly from child class constructor using base keyword 
                1. The constructor for the base class is called before the block for the constructor is executed. 
                2. The base keyword can be used with or without parameters. 
                3. Any parameters to the constructor can be used as parameters to base class constructor
 
                EX: - 
                     //it will call base class default constructor
                        public ChildClassConstructor() : base()
                        {
                            Console.WriteLine("child Class public Constructor called");
                        }

                    //it will call base class parameterized constructor first and then current constructor and in this case it wont call base class default constructor
                        public ChildClassConstructor() : base(10,"Test")
                        {
                            Console.WriteLine("child Class public Constructor called");
                        }
 
 
            * Usage of "this" keyword 
 
                1. we can use "this" to have one constructor invocation call another constructor method in same class

                       //It will call parameterized constructor of same class first i.e. which is having parameter as integer
                         public ChildClassConstructor():this(10)
                         {
                             Console.WriteLine("child Class public Constructor called");
                         }
           ====================================================================================================================================================================
*/

#endregion Points To Remember
namespace OOPSConcept
{
    class Constructors
    {
        public Constructors()
        {
            Console.WriteLine("Public Constructor Called");
        }
        private Constructors(int x)
        {
            Console.WriteLine("Private Constructer Called");
        }
        public Constructors(int x, string name)
        {
            Console.WriteLine("Public parameterized Constructor Called");
        }
        static Constructors()
        {
            ;            //int i = 0; // valid
            //static int i = 0; // Not valid
            Console.WriteLine("Static Constructor Called");
        }
       
        public class SubClassConstructor
        {
            public SubClassConstructor()
            {
                Console.WriteLine("SubClassConstructor public constructor called");
            }
            private SubClassConstructor(int x)
            {
                Console.WriteLine("SubClassConstructor Private Constructor called");
            }
            public SubClassConstructor(int x, string name)
            {
                Console.WriteLine("SubClassConstructor public parameterized constructor called");
            }
            static SubClassConstructor()
            {
                Console.WriteLine("SubClassConstructor static constructor called");
            }
        }
    }

    class ChildClassConstructor : Constructors
    {

        //it will call base class default constructor
        //public ChildClassConstructor() : base()
        //{
        //    Console.WriteLine("child Class public Constructor called");
        //}

        //it will call base class parameterized constructor constructor
        //public ChildClassConstructor() : base(10,"Test")
        //{
        //    Console.WriteLine("child Class public Constructor called");
        //}

        //we can use "this" to have one constructor invocation call another constructor method in same class
        //public ChildClassConstructor():this(10)
        //{
        //    Console.WriteLine("child Class public Constructor called");
        //}
        public ChildClassConstructor()
        {
            Console.WriteLine("child Class public Constructor called");
        }
        private ChildClassConstructor(int x)
        {
            Console.WriteLine("Child Class Private constructor called");
        }
        public ChildClassConstructor(int x, string name) 
        {
            Console.WriteLine("child Class public parameterized Constructor called");
        }
        static ChildClassConstructor()
        {
            Console.WriteLine("Child Class Static Constructor Called");
        }
    }

    class ConstructorMain
    {
        static void Main(string[] args)
        {
            Constructors C = new Constructors();
            Constructors C1 = new Constructors();
            Constructors Cc = new Constructors(10, "");
            ChildClassConstructor CCC = new ChildClassConstructor(10, "");
            ChildClassConstructor ccc = new ChildClassConstructor();
        }
    }
}
