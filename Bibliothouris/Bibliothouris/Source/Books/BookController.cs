using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;

namespace Bibliothouris.Source.Books
{
    class BookController
    {
        internal IBookView view { get; }
        private IBookAddView addBook;
        private IBookService service;

        public BookController(IBookService service, IBookView view,IAddBook addBook)
        {
            this.view = view;
            this.addBook = addBook;
            this.service = service;
            this.view.SetController(this);
            this.addBook.SetController(this);
        }
        public void LoadAllBooks()
        {
            foreach (Book book in service.getAllBooks())
            {
                view.AddBook(book);
            }
        }
        public void AddBook (string ISBN, string title, string AuthorFirstName, string AuthorLastName)
        {
            service.AddBook(ISBN, title, AuthorFirstName, AuthorLastName);
            addBook.close();
            ClearAllBooks();
            LoadAllBooks();
        }
        private void ClearAllBooks()
        {
            view.ClearAllBooks();
        }
        public void AddBooks()
        {
            addBook.Clear();
            addBook.ShowDialog();
        }
    }
}
