using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Employee2
    {
        public int Empid;
        public string Ename;
        public double Grosspay;
          double TaxDeduction = 0.1;
        double NetSalary;
        public Employee2(int Eid,string Name,double EGrosspay)
        {
            this.Empid = Eid;
            this.Ename = Name;
            this.Grosspay = EGrosspay;
        }
        void CalculateSalary()
        {
            if(Grosspay>=25000)
            {
                NetSalary = Grosspay - (TaxDeduction * Grosspay);
                Console.WriteLine("your salary is"+NetSalary);
            }
            else
            {
                Console.WriteLine("your salary is "+Grosspay);
            }
            
        }
        public void printdetails()
        {
            Console.WriteLine("Employee id is"+this.Empid);
            Console.WriteLine("Employee ename is"+this.Ename);
            
            this.CalculateSalary();
        }

    }
    class Abstraction
    {
        static void Main(string[]args)
        {
            Employee2 E2 = new Employee2(101, "imran", 60000);
            E2.printdetails();
            Console.ReadLine();
              
        }
    }
}
