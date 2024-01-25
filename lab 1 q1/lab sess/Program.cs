using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input length");
            int length=Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Input width");
            int width=Convert.ToInt16(Console.ReadLine());

            int CalculateArea= Area(length, width);

            Console.WriteLine($"Area is {CalculateArea}");
            Console.ReadLine();
        }
        static int Area(int length,int width)
        {
            int area = length * width;
            return area;
        }
    }
}
