using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the marks of the students");
            int mark = int.Parse(Console.ReadLine());

            
                if (mark >= 75 && mark <= 100)
                {
                    Console.WriteLine(name + ": Grade A");
                  
                }
                else if (mark >= 60 && mark <= 74)
                {
                    Console.WriteLine(name + ": Grade B");
                   
                }
                else if (mark >= 50 && mark <= 59)
                {
                    Console.WriteLine(name + ": Grade C");
                  
                }
                else if (mark >= 40 && mark <= 49)
                {
                    Console.WriteLine(name + ": Grade D");
                }
                else if (mark < 40)
                {
                    Console.WriteLine(name + ": Failed");
                }
                else if (mark < 0 && mark > 100)
                {
                    Console.WriteLine(name + ": Error!");
                }
            Console.ReadLine();

        }
    }
}
