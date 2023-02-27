using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{

    public delegate void calculations(int num1, int num2);
    class Multicastdelegates
    {
        public static void Add(int num1, int num2)
        {
            int c = num1 + num2;
            Console.WriteLine("addition is" + c);
        }
        public static void subs(int num1, int num2)
        {
            int c = num1 - num2;
            Console.WriteLine("subs is" + c);
        }
        public static void mul(int num1, int num2)
        {
            int c = num1 * num2;
            Console.WriteLine("mul is" + c);
        }
        public static void div(int num1, int num2)
        {
            int c = num1 / num2;
            Console.WriteLine("div is" + c);
        }
        static void Main(string[] args)
        {
            calculations obj = new calculations(Add);
            obj += subs;
            obj += mul;
            obj -= div;
           obj(20, 40);
            Console.ReadLine();


        }
    } }
