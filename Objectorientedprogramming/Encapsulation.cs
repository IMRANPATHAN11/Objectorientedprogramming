using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Person
    {
        private string name;
        private int age;
        public void setname(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("name is required");
            }
            else
            {
                this.name = name;
            }

        }
        public void getname()
        {
            if (string.IsNullOrEmpty(this.name) == true)
            {

            }
            else
            {
                Console.WriteLine("your name is" + this.name);
            }
        }
        public void setage(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("age should be not negative");
            }
        }
        public void getage()

        {
            if (this.age > 0)
            {
                Console.WriteLine("your age is" + this.age);
            }
            else
            {

            }
        } 
    }
        class Encapsulation
        {
             public static void Main(string[] args)
            {
                Person P1 = new Person();
                P1.setname("imran");
                P1.setage(21);
                P1.getname();
                P1.getage();
                Console.ReadLine();
            }

        }
    }

