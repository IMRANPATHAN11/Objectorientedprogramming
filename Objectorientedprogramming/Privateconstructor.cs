using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{   
    class rectangle4
    {
        private int length, breadth, area, perimeter;
        static rectangle4 R;
        private rectangle4()
        {
            Console.Write("enter length,breadth of the reatangle");
            this.length = Convert.ToInt32(Console.ReadLine());
            this.breadth = Convert.ToInt32(Console.ReadLine());
        }
        public static rectangle4 GetRectangleobject()
        {
            R = new rectangle4();
            return R;
        }
        public void Findarea()
        {
            this.area = this.length * this.breadth;
        }
        public void findperimeter()
        {
            this.perimeter = 2 * (this.length + this.breadth);
        }
        public override string ToString()
        {
            string output = "length is" + this.length + "\n breadth is" + this.breadth + "\n area is " + this.area + "\n parimeter is " + this.perimeter;
            return output;
        }
    }

    
    class Privateconstructor
    {
            static void Main(string[] args)
            {
                rectangle4 R1 = rectangle4.GetRectangleobject();
                R1.Findarea();
                R1.findperimeter();
                Console.WriteLine(R1);
                Console.ReadLine();
            }
        }
}
