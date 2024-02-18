using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101,"John Doe",50000);

            employee1.DisplayEmployeeInfo();

            Console.WriteLine("Updated Employee Information:");
            //updating name
            employee1.fullName = "Krystal Smith";
            employee1.salary = 60000;
            employee1.DisplayEmployeeInfo();
            Console.ReadLine();
        }
    }
}
