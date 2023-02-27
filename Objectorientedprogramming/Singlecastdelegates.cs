using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    public delegate void calculation(int num1,int num2);
    class Singlecastdelegates
    {
        public static void addition(int num1, int num2)
        {
            int result = num1 +num2;
            Console.WriteLine("addition is" + result);

        }
        static void Main(string[] args)
        {
            calculation c = new calculation  (Singlecastdelegates.addition);
            c(20, 28);
            Console.ReadLine();

        }
    }
}
