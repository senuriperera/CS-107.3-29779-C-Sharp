using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the multiplication table needed");
            int num =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter upto what times(number) you need");
            int length= int.Parse(Console.ReadLine());

           
            for(int i = 1; i <= length; i++) 
            { 
              int ans = i * num;
                Console.WriteLine(i + " x " + num + " = " + ans);   
            }
            Console.ReadLine();
        }
    }
}
