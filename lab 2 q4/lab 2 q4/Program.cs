using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Iphone",79999.99);
            Product product2 = new Product("Smart TV",125000);

            Console.WriteLine("Product Name:" + product1.ProductName);
            Console.WriteLine("Price: Rs." + product1.Price);
            Console.WriteLine("Product Name:" + product2.ProductName); 
            Console.WriteLine("Price: Rs." + product2.Price);
            Console.ReadLine();
        }
    }
}
