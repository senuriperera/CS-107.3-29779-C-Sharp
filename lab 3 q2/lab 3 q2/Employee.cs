using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q2
{
    internal class Employee
    {
        private int employeeID;
        private string FullName;
        private double Salary;

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
        }
        public string fullName
        {
            get { return FullName; }
            set { FullName= value;}
        }
        public double salary
        {
            get { return Salary; }
            set { Salary= value;}
        }

        public Employee(int employeeID, string FullName,double Salary)
        {
            this.employeeID = employeeID;
            this.FullName = FullName;
            this.Salary = Salary;
        }
        public void DisplayEmployeeInfo()
        {

            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Salary: Rs.{Salary}");
        }
    }
}
