using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;

namespace OOPSConcept
{
    class Collections : IDisposable
    {
        //[MethodImpl(MethodImplOptions.InternalCall)]
        //[SecuritySafeCritical]
        
        /// <summary>
        /// dsdsds
        /// </summary>

        public void Non_Generic_ArrayList()
        {
            StringBuilder s = new StringBuilder();
            
            Object arraylistval = null;
            ArrayList arr = new ArrayList();
            arr.Add("Praveen");
            arr.Add(10);
            arr.Add(10.455);
            arr.Add(true);
            arr.Add(DateTime.Now);          
            //arr.Add(null);

            foreach(var item in arr)
            {
                arraylistval += item.ToString();
                if (arraylistval != null)
                    arraylistval += ",";
            }
            Console.WriteLine(arraylistval);           
         }
        void IDisposable.Dispose()
        {

        }
        public void Non_Generic_HashTable()
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "PK");
            HT.Add("PK", 1);
            HT.Add(2, null);
        }

        public void Non_Generic_Stack()
        {
            Stack st = new Stack();
            st.Push("Praveen");
            st.Push(1);
            st.Push(12);
            st.AsQueryable();
            
        }


        public static void Main()
        {
            using(Collections ob = new Collections())
            {
                ob.Non_Generic_ArrayList();
            }
            Collections obj = new Collections();
            obj.Non_Generic_ArrayList();
            //dynamic a = obj.MemberwiseClone();
            //a.NonGenericCollections();
            obj.Non_Generic_HashTable();
            Console.ReadKey();

        }
    }
}
