using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "J.K.Rowling";

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.ReadLine();
        }
    }
    class Book
    {
        public string title;
        public string author;
    }
}
