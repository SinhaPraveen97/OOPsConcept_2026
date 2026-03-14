using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    /* Points to Remember
     * 
     * 1. Ref and Out keyword are used to pass an argument as a reference. This means that when value of that parameter is changed in the method,
                its gets reflected in the calling method.
      
            //Called Method
                static void Example1(ref int value) //called method
                {
                value = 1;
                }
       
            //Calling Method 
            
                public static void Main() //calling method
                {
                int val1 = 0; //must be initialized 
                int val2; //optional
                
                Example1(ref val1);
                Console.WriteLine(val1); // val1=1
                
                Example2(out val2);
                Console.WriteLine(val2); // val2=2
                }
     * 
     * 2. Ref Keyword Vs Out Keyword
                1. An argument passed by Ref keyword must be initialized in the calling method before it is passed to called method.
                2. An argument passed by Out Keyword must be initialized in the called method before it returns back to calling method.
     * 
     * 3. Method that only defers Ref and Out keyword cannot be overloaded
                class CS0663_Example
                {
                    // Compiler error CS0663: "Cannot define overloaded 
                    // methods that differ only on ref and out".
                    public void SampleMethod(out int i) { }
                    public void SampleMethod(ref int i) { }
                }
     * 
     * 4. Method can be overloaded when one method has a ref/out keyword and the other method has a value parameter.
                class RefOverloadExample
                {
                    public void SampleMethod(int i) { }
                    public void SampleMethod(ref int i) { }
                }
     
     */
    //class RefAndOutKeyword
    //{
    //    public void RefMethod(ref int i) // Called method
    //    {
    //         i = 10; // Optional            
    //    }
    //    public void RefMethod(out int i) // Called method
    //    {
    //        i = 10; // Optional            
    //    }

    //    public void M1(ref int i, out int y)
    //    {

    //    }
        

    //    public void RefMethod(int i)
    //    {

    //    }
    //    public void OutMethod(out int x)
    //    {
    //        x = 11; // Must be initialized            
    //    }
    //    public void PlainMethod(int Val)
    //    {
    //        Val = 100;
    //    }
    //}
    //class RefAndOutMain
    //{
    //    public static void Main(string[] args)
    //    {
    //        int i = 1; // ref variable must be initialized
    //        int x = 2; // Optional
    //        int val = 23; // used for passing to Plain Method
    //        RefAndOutKeyword obj = new RefAndOutKeyword();
            
    //       // int a;
    //       // obj.RefMethod(ref a); //compile time error // used of unassigned variable.
    //       // obj.OutMethod(out a); // No Error // initializing a variable with out parameter is optional




    //        obj.RefMethod(ref i); 
    //        Console.WriteLine(i);// Print 10
    //        obj.OutMethod(out x);
    //        Console.WriteLine(x);// Print 11
    //        obj.PlainMethod(val);
    //        Console.WriteLine(val);// Print 23
    //        Console.ReadKey();
    //    }
    //}

    class abc
    {

        
        //public void ABC (ref int i, out int y)
        //{
        //    y = 10;
        //}
        //public void BCD(out int i)
        //{
        //    i = 6;
        //}
        public void ABC( out int y,ref int i)
        {
            y = 10;
        }
        public void BCD(ref int i,ref int a)
        {
            i = 6;
        }
        public static void Main(string [] args)
        {
            abc ab = new abc();
            int i = 10;
            //int j = 20;
            //ab.ABC(ref i, out j);
            ab.BCD(ref i,ref i);
        }
    }
}
