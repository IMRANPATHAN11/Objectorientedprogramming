using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Rectangle1
    {
        private int length, breadth, Area;
        public Rectangle1(int L, int B)
        {
            this.length=L;
            this.breadth=B;
        }
        public void findpArea()
        {
            this.Area = this.length * this.breadth;
        }
        public override string ToString()
        {
            string output   = "lenght is" + this.length + "\n Breadth  is" + this.breadth + "\n Area is" + this.Area;
            return output;
        }
    }
    class Parameterisedcon
    {
        static void Main(string[]args)
        {
            Rectangle1 R = new Rectangle1(200, 100);
            R.findpArea();
            Console.WriteLine(R);
            Console.ReadLine();
        }
    }
}
