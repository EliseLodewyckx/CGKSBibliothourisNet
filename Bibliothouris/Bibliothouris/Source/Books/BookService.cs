using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
    class BookService
    {
        public interface IUBooksService
        {
            List<Book> getAllBooks();
            void AddBook(Book book);
        }
        public class Bookservice : IUBooksService
        {
            private BookRepository bookRepository;

            public Bookservice() : this(new BookRepository())
            {
            }
            public Bookservice(BookRepository bookRepository) {
                this.bookRepository = bookRepository;

            }
            public List<Book> getAllBooks()
            {
                return bookRepository.getAllBooks();
            }
            public void AddBook(Book book)
            {
                bookRepository.AddBook(book);
            }
        }
    }
}
/*
   
     
 */
