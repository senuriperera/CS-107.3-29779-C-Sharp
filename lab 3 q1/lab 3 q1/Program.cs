using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("Math", "Mr. Smith", 85);
            course.PrintCourseInfo();
            Console.ReadLine(); 
        }
    }
}
