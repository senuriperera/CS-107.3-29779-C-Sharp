using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_ques_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101,"John Doe",50000);

            employee1.displayEmployeeID();
            employee1.salary = 40000;
            // salary cant be accessed to its protection level
            Console.ReadLine();
        }
    }
}
