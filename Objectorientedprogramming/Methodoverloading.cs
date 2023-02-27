using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Calculation
    { 
        public  void Add()
        {
            int a = 50;
            int b = 50;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(string a,string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(float a,float b)
        {
            float c =a+b;
            Console.WriteLine(c);

        }

    }
    class Methodoverloading
    {
        static void Main(string[]args)
        {
            Calculation C = new Calculation();
            C.Add();
            C.Add(2, 4);
            C.Add("imrankhan","ik");
            C.Add(1.2f, 2.8f);
            Console.ReadLine();
        }
    }
}
