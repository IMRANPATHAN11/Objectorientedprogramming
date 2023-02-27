using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class AccessSpecifiers2:AccessSpecifiers //derived class
    {
        static void Main(string[]args)
        {
            AccessSpecifiers2 a2 = new AccessSpecifiers2();
           
            a2.Protected2();
            a2.internal3();
            a2.protectedinternal4();
            a2.Privateprotected5();
            a2.public6();
            Console.ReadLine();
        }
    }
}
