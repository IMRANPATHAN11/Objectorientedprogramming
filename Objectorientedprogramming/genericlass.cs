using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{

    class sample7<tp>
    {
        public void display(tp p1)
        {
            Console.WriteLine("value is" + p1);

        }
    }

    class genericlass
    {
        static void Main(string[] args)
        {
            sample7<int> obj1 = new sample7<int>();
            sample7<string> obj2 = new sample7<string>();
            sample7<double> obj3 = new sample7<double>();
            obj1.display(20);
            obj2.display("khan");
            obj3.display(2.77);
            Console.ReadKey();
        }
    }
}
