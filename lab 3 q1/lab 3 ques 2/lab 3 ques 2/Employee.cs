using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_ques_2
{
    internal class Employee
    {
        private int employeeID;
        private string fullName;
        private double salary;

        public Employee(int employeeID, string fullName, double salary)
        {
            this.employeeID = employeeID;
            this.fullName = fullName;
            this.salary = salary;
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        public string Name
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            { salary = value; }
        }

        public void displayEmployeeID()
        {
            Console.WriteLine("Employee ID: " +  employeeID);
            Console.WriteLine("Full Name: " +  fullName);
            Console.WriteLine("salary: " + salary);
        }

           
    }
}
