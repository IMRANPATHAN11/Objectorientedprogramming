using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class rectangle3
    {
        private int length, breadth, Area, Perimeter;
        public rectangle3()
        {
            Console.Write("enter length & breadth of the rectangle");
            this.length = Convert.ToInt32(Console.ReadLine());
            this.breadth = Convert.ToInt32(Console.ReadLine());
        }
        public rectangle3(rectangle3 R)
        {
            this.length = R.length;
            this.breadth = R.breadth;

        }
        public void FindArea()
        {
            this.Area = this.length * this.breadth;
        }
        public void FindPerimeter()
        {
            this.Perimeter = 2 * (this.length + this.breadth);
        }
        public override string ToString()
        {
            string output = "length is" + this.length + "\n breadth is" + this.breadth + "\n area is" + this.Area + "perimeter is" + this.Perimeter;
            return output;
        }
    }
    class Copyconstructor
    {
        static void Main(string[]args)
        {
            rectangle3 R1 = new rectangle3();
            rectangle3 R2 = new rectangle3(R1);
            rectangle3 R3 = R1;
            R1.FindArea();
            R1.FindPerimeter();
            R2.FindArea();
            R2.FindPerimeter();
            R3.FindArea();
            R3.FindPerimeter();
            Console.WriteLine(R1);
            Console.WriteLine(R2);
            Console.WriteLine(R3);
            Console.ReadLine();
        }
    }
    }
    

