using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class sample
    {
        int x;
        static int y;
        public sample()
        {
            x = 100;
        }
        static sample()
        {
            y = 100;
        }
        public void display()
        {
            Console.Write(x + "\t");
            x++;
            Console.WriteLine(y);
            y++;
        }
    }
    class Staticconstructor
    {
        static void Main(string[]args)
        {
            Console.WriteLine("x \t y\n_____ ");
            sample obj1 = new sample();
            obj1.display();
            sample obj2 = new sample();
            obj2.display();
            sample obj3 = new sample();
            obj3.display();
            Console.ReadLine();
        }
        
    }
}
