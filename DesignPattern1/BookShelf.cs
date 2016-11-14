using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern01_Iterator
{
    class BookShelf : IAggregate
    {
        List<Book> books;

        public BookShelf(int maxsize)
        {
            books = new List<Book>();
        }
        
        public Book GetBookAt(int index)
        {
            return (index < books.Count) ? books[index] : null;
        }

        public void AppendBook(Book book)
        {
            books.Add(book);
        }

        public int GetLength()
        {
            return books.Count;
        }

        public IIterator iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
