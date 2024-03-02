using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the course name:");
            string cName = Console.ReadLine();

            Console.WriteLine("Enter the instructor name:");
            string instructName = Console.ReadLine();

            Console.WriteLine("Enter the grade:");
            double grade = Convert.ToDouble(Console.ReadLine());

            Course course = new Course();
           
            course.PrintCourseInfo();
            Console.ReadLine();


        }
    }
}
