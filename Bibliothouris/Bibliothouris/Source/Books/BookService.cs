using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        void AddBook(string isbn, string title, string firstName, string lastName);
        List<Book> SearchBooks(string isbn, string title, string firstName, string lastName);
        Book GetBookByISBN(string ISBN);
    }

    class BookService : IBookService
    {
        private BookRepository bookRepository;

        public BookService(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public List<Book> GetAllBooks()
        {
            return bookRepository.getAllBooks();
        }

        public void AddBook(string isbn, string title, string firstName, string lastName)
        {
            bookRepository.AddBook(new Book(title, isbn, firstName, lastName));
        }

        public List<Book> SearchBooks(string isbn, string title, string firstName, string lastName)
        {
            
            return bookRepository.getBooksByDetails(isbn, title, firstName, lastName);
        }

        public Book GetBookByISBN(string ISBN)
        {
            return bookRepository.getBooksByDetails(ISBN,"","","")[0];
        }
       
        }
    }
