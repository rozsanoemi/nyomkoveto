using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nyomkoveto
{
    public class A
    {
        public void S1()
        {
            Console.WriteLine("A::S1");
            Console.ReadKey();
            V1();
            
        }

        protected virtual void V1()
        {
            Console.WriteLine("A::V1");
            Console.ReadKey();
            S3();
            
        }

        public void S2()
        {
            Console.WriteLine("A::S2");
            Console.ReadKey();
            S1();
        }

        private void S3()
        {
            Console.WriteLine("B::S3");
            Console.ReadKey();
        }
    }
}