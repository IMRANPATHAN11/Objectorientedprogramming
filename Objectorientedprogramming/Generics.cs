using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class sample6
    {
        public void display<tp>(tp p1)
            {
            Console.WriteLine("value is"+p1);

        }
    }
    class Generics
    {
        static void Main(string[]args)
        {
            sample6 obj1 = new sample6();
            obj1.display<int>(20);
            obj1.display<string>("imran");
            obj1.display<double>(1.2);
            Console.ReadLine();
        }
    }
}
