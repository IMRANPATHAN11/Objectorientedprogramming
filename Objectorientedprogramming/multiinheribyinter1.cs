using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    interface I1
    {
        void M1();
    }
    interface I2
    {
        void M2();
    }
    class C3: I1 , I2
    {
        public void M1()
        {
            Console.WriteLine("WELCOME");
        }
        public void M2()
        {
            Console.WriteLine("HELLO");
        }
    }


    class multiinheribyinter1
    {
        static void Main(string[]args)
        {
            C3 obj1 = new C3();
            obj1.M1();
            obj1.M2();
            Console.ReadLine();
        }
    }
}
