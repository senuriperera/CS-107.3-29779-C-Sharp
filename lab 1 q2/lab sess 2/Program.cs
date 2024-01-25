using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sess_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Enter number "+ (i+1) +":");

                    int num = Convert.ToInt16(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Even number");
                    }
                    else
                    {
                        Console.WriteLine("Odd Number");
                    }

                 
                }
            }
        }
    }
}

