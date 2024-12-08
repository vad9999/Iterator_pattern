using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));

            IIterator iterator = library.CreateIterator();

            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }
    }
}
