using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_assignment
{
    class Book
    {
        Book()
        {
            Console.WriteLine("default book constructor");
        }
        Book(string title, string author)
        {
            Console.WriteLine("title is " + title + " author is " + author);
        }
        Book(string title, string author, string isbn)
        {
            Console.WriteLine("title is " + title + " author is " + author + "isbn is  " + isbn);
        }
        //public static void Main(string[] args)
        //{
        //    Book book = new Book();
        //    Book book1 = new Book("book1", "sowmya");
        //    Book book2 = new Book("book2", "sowmya", "234567");
        //}
    }
}
