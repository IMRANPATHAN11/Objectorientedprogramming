using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectorientedprogramming
{
    class Employee
    {
        int Empid; string Ename, Designation;
        double Salary;
        public int PEmpid
        {
            set
            {
                this.Empid = value;
            }
            get
            {
                return this.Empid;
            }
        }
        public string PEname
        {
            set
            {
                this.Ename = value;
            }
            get
            {
                return this.Ename;
            }

        }
        public string PDesignation
        {
            set
            {
                this.Designation = value;
            }
            get
            {
                return this.Designation;
            }

        }
        public double PSalary
        {
            set
            {
                this.Salary = value;
            }
            get
            {
                return this.Salary;
            }
        }
    }
    class Properties
    {
        static void Main(string[]args)
        {
            Employee E1 = new Employee();
            Console.Write("enter employee details....");
            E1.PEmpid = Convert.ToInt32(Console.ReadLine());
            E1.PEname = Console.ReadLine();
            E1.PDesignation = Console.ReadLine();
            E1.PSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee id is="+E1.PEmpid);
            Console.WriteLine("Employee name is="+E1.PEname);
            Console.WriteLine("Employee designation is="+E1.PDesignation);
            Console.WriteLine("Employee salary is="+E1.PSalary);
            Console.ReadLine();
        }
    }
}
