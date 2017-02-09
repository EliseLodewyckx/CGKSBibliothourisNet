using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
    public interface IBookService
    {
        List<Book> GetAllBooks();

        void AddBook(string txtIsbnText, string txtTitleText, string txtFirstNameText, string txtLastNameText);
        List<Book> SearchBooks(string isbn, string title, string firstName, string lastName);
    }

    class BookService: IBookService
    {
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public void AddBook(string txtIsbnText, string txtTitleText, string txtFirstNameText, string txtLastNameText)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchBooks(string isbn, string title, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
