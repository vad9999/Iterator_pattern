using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_pattern
{
    public class Library : ILibraryCollection
    {
        private ArrayList books;

        public Library()
        {
            books = new ArrayList();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public IIterator CreateIterator()
        {
            return new LibraryIterator(this);
        }

        public int Count => books.Count;

        public Book this[int index]
        {
            get { return (Book)books[index]; }
        }

        private class LibraryIterator : IIterator
        {
            private Library library;
            private int currentIndex;

            public LibraryIterator(Library library)
            {
                this.library = library;
                currentIndex = 0;
            }

            public bool HasNext()
            {
                return currentIndex < library.Count;
            }

            public Book Next()
            {
                if (!HasNext())
                    throw new InvalidOperationException("No more books in the library.");

                return library[currentIndex++];
            }
        }
    }
}
