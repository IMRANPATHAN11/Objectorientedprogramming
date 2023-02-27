using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Student
    {
        public int rollno;
        public string sname;
        public string lastname;
        public void fullname()
        {
            string fullname = sname +" "+ lastname;
            Console.WriteLine("your full name is.."+fullname);
        }


    }
    class Instancem
    {
        static void Main(string[]args)
        {
            Student s1 = new Student();
            s1.rollno = 21;
            s1.sname = "imran";
            s1.lastname = "khan";
            Console.WriteLine(s1.rollno);
            Console.WriteLine(s1.sname);
            Console.WriteLine(s1.lastname);
            s1.fullname();
            Console.ReadLine();

                
        }
    }
}
