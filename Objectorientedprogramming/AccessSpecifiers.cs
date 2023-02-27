using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
   

     public class AccessSpecifiers
    {
        private void Private1()
        {
            Console.WriteLine("private");
        }
        protected void Protected2()
        {
            Console.WriteLine("potetcted");
        }
        internal void internal3()
        {
            Console.WriteLine("internal");
        }
      
        protected internal void protectedinternal4()
        {
            Console.WriteLine("protected internal");
        }
        private protected void Privateprotected5()
        {
            Console.WriteLine("private protected");
        }
        public  void public6()
        {
            Console.WriteLine("public");
        }
        static void Main(string[]args)
        {
            AccessSpecifiers a = new AccessSpecifiers();
            a.Private1(); 
            a.Protected2();
            a.internal3(); 
            a.protectedinternal4();
            a.Privateprotected5();
            a.public6();
            Console.ReadLine();

        }
    }
}
