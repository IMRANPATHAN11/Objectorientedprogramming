using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Employee1
    {

        int Empid; string Ename, Designation;
        double Salary;
        public int PEmpid
        {
            set { this.Empid = value; }
            get { return this.Empid; }
        }
        public string PEname
        {
            set
            {
                if (value.Trim().Length == 0)
                
                    this.Ename = "imran";
                
                else
                    this.Ename = value;
            }
            get { return this.Ename; }
        }
        public string PDesignation
        {
            set { this.Designation = value; }
            get { return this.Designation; }
        }
        public double PSalary
        {
            set
            {
                if (value >= 25000)
                    this.Salary = value;
                else
                    this.Salary = 25000;
            }
            get { return this.Salary; }
        }
    }
    class Properties1
    {
        static void Main(string[]args)
        {
            Employee1 E2 = new Employee1();
            Console.Write("enter employee details....");
            E2.PEmpid = Convert.ToInt32(Console.ReadLine());
            E2.PEname = Console.ReadLine();
            E2.PDesignation = Console.ReadLine();
            E2.PSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee id is=" + E2.PEmpid);
            Console.WriteLine("Employee name is=" + E2.PEname);
            Console.WriteLine("Employee designation is=" + E2.PDesignation);
            Console.WriteLine("Employee salary is=" + E2.PSalary);
            Console.ReadLine();
        }
    }
}
