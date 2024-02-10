using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_q3
{
     internal class Program
     {
         static void Main(string[] args)
         {
             TemperatureTracker temperature = new TemperatureTracker();

             temperature.inputTemperature();
             temperature.displayTemperature();
            Console.ReadLine();
         }
     }

     class TemperatureTracker
     {
         public double[] dailyTemperature = new double[7];
         public void inputTemperature()
         {

             for (int i = 0; i < dailyTemperature.Length; i++)
             {
                 Console.Write("Enter temperature of day "+ (i+1)+":");
                dailyTemperature[i] = Convert.ToDouble(Console.ReadLine());
             }
         }
        public void displayTemperature()
        {
            Console.WriteLine("Weekly Temperature report:");
            for(int i = 0;i < dailyTemperature.Length;i++)
            {
                Console.Write($"Day {i + 1}: {dailyTemperature[i]}°C \n");
            }
            Console.ReadLine();
        }
     }
 }
    
  

 

