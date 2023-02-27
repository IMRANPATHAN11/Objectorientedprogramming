using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class conoverloading
    {
        public conoverloading()
        {
            Console.WriteLine("this is a first constructor !!");
        }
        public conoverloading(int a, int b)
        {
            Console.WriteLine("this is a Second constructor !! {0}", (a + b));
        }
        public conoverloading(int a, int b, int c)
        {
            Console.WriteLine("this is a third constructor !! {0}", (a + b + c));
        }
        public conoverloading(string a, string b, string c)
        {
            Console.WriteLine("this is a fourth constructor !! {0}", (a + b + c));
        }
    

        
        
            static void Main(string[] args)
            {
                // CONSTRUCTOR OVERLOADING 
               conoverloading O = new conoverloading(200,200 );
                Console.ReadLine();
            }
        } }
