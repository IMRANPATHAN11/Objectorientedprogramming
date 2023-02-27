using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("this is a method of parent class");
        }
    }
    class child:parent
    {
        public override void print()
        {
            Console.WriteLine("this is a method of child class");
        }
    
    }
    class Methodoverriding
    {
     static void Main(string[]args)
    {
            parent p = new child();
            p.print();
            Console.ReadLine();
    }
    }
}
