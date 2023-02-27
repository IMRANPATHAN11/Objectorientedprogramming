using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    abstract class perosn6
    {
        public string name;
        public int age;
        public string mobilnumber;
        public abstract void printdetails();
    }
    class student : perosn6
    {
        public int rollno;
        public int fees;
         public override void printdetails()
        {
            Console.WriteLine("student name is=" + this.name);
            Console.WriteLine("student age is=" + this.age);
            Console.WriteLine("student mobilnumber is=" + this.mobilnumber);
            Console.WriteLine("student roll no is=" + this.rollno);
            Console.WriteLine("student fees is=" + this.fees);
        }
    }
    class teacher:perosn6
    {
        public string qualifaction;
        public int salary;
        public override void printdetails()
        {
            Console.WriteLine("teacher name is=" + this.name);
            Console.WriteLine("teacher age is=" + this.age);
            Console.WriteLine("teacher mobilnumber is=" + this.mobilnumber);
            Console.WriteLine("teacher qualificatio is=" + this.qualifaction);
            Console.WriteLine("teacher salary is=" + this.salary);
        }
    }
    class Abstractc
    {
        static void Main(string[]args)
        {
            student s = new student();
            s.name = "imran";
            s.age = 22;
            s.mobilnumber = "9373658858";
            s.rollno = 101;
            s.fees = 20000;
            s.printdetails();
            Console.WriteLine("-----------------------------------");
            teacher t = new teacher();
            t.name = "naresh";
            t.age = 44;
            t.mobilnumber = "1111111111";
            t.qualifaction ="phd";
            t.salary = 200000;
            t.printdetails();
            Console.WriteLine("-----------------------------------");

            Console.ReadLine();

        }
    }

}
