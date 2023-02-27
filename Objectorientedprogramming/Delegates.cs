using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    public delegate void calculate(int a, int b);
    class Delegates
    {
        public static void Addition(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("addition is" + c);
        }
        public static void Substract(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("substract is" + c);
        }
        public static void multiply(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("multiply is" + c);
        }
        public static void divide(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("divide is" + c);
        }
        static void Main(string[] args)
        {
            calculate c = new calculate(Delegates.Addition);
            c(20, 28);
            c = Substract;
            c(30, 40);
            c = multiply;
            c(30, 10);
            c = divide;
            c(10, 2);
            Console.ReadLine();
        }
    }
}


         
