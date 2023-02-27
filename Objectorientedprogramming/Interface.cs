using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    interface shape
    {
        void Acceptdata();
        void Findarea();
        void Findperimeter();
    }
        class Rectangle6: shape
        {
        int lenght, breadth, area, perimeter;
        public void Acceptdata()
        {
            Console.Write("enter length and breadth");
            this.lenght = Convert.ToInt32(Console.ReadLine());
            this.breadth = Convert.ToInt32(Console.ReadLine());
        }
        public void Findarea()
        {
            this.area = this.lenght * this.breadth;
        }
        public void Findperimeter()
        {
            this.perimeter = 2 * (this.lenght + this.breadth);
        }
        public override string ToString()
        {
            string output = "length is" + this.lenght + "\n breadth is " + this.breadth + "\n area is" + this.area + "\n perimeter  is" +
                this.perimeter;
            return output;
        }

    }
    
    class Interface
    {
        static void Main(string[] args)
        {
            Rectangle6 R = new Rectangle6();
            R.Acceptdata();
            R.Findarea();
            R.Findperimeter();
            Console.WriteLine(R);
            Console.ReadLine();
        }


    }
}
