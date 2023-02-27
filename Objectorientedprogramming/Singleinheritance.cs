using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class rectangle5
    {
        public int length, breadth, area, perimeter;
        public void Acceptdata()
        {
            Console.Write("enter length and breadth");
            length = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
        }
        public int findarea()
        {
            this.area = this.length + this.breadth;
            return area;

        }
        public void findperimter()
        {
            this.perimeter = 2 * (this.length + this.breadth);
        }
        public override string ToString()
        {
            string output = "length " + this.length + "breadth" + this.breadth + "area" + this.area + "perimter" + this.perimeter;
            return output;
        }
    }
         class cuboid:rectangle5
    {
        int height, volume,tsa;
        public void acceptheight()
        {
            Console.Write("enter height");
            this.height = Convert.ToInt32(Console.ReadLine());
        }
        public void findvolume()
        {
            this.volume = base.findarea() * this.height;
        }
        public void findtsa()
        {
            this.tsa = (base.length * base.breadth + base.breadth * this.height + this.height * base.length);
        }
        public override string ToString()
        {
            string output = "volume" + this.volume + "\n total surface area" + this.tsa;
            return output;
        }

    }
    
    class Singleinheritance
    {
        static void Main(string[]args)
        {
            cuboid c1 = new cuboid();
            c1.Acceptdata();
            c1.acceptheight();
            c1.findarea();
            c1.findperimter();
            c1.findvolume();
            c1.findtsa();
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
