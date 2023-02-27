using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{   
    class rectangle
    {
        private int length, breadth,Area;
        public rectangle()
        {
            Console.Write("enter lenght and bradth ..");
            this.length = Convert.ToInt32(Console.ReadLine());
            this.breadth = Convert.ToInt32(Console.ReadLine());
        }
        public void findpArea()
        {
            this.Area = this.length * this.breadth;
        }
        public override string ToString()
        {
            string output = "lenght is" + this.length + "\n Breadth  is" + this.breadth + "\n Area is" + this.Area;
            return output;
        }
    }
    class Defaultconstructor
    {
        public static void Main(string[]args)
        {
            rectangle R1 = new rectangle();
            R1.findpArea();
            Console.WriteLine(R1);
            Console.ReadLine();

        }
    }
}
