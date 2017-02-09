using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms.BookForm;

namespace Bibliothouris.Source.Books
{
    public class BookController
    {
        internal IBookView bookView { get; }
        private IBookAddView addBookView;
        private IBookSearchView bookSearchView;
        private IBookService bookService;

        public BookController(IBookAddView addBookView, IBookSearchView bookSearchView, IBookService bookService,
            IBookView bookView)
        {
            this.addBookView = addBookView;
            this.bookSearchView = bookSearchView;
            this.bookService = bookService;
            this.bookView = bookView;
            this.bookView.SetController(this);
            this.addBookView.SetController(this);
            this.bookSearchView.SetController(this);
        }

        public void ShowAddBook()
        {
            addBookView.Clear();
            addBookView.ShowDialog();
        }

        public void SearchBookView()
        {
            bookSearchView.Clear();
            bookSearchView.ShowDialog();
        }

        public void AddBook(string txtIsbnText, string txtTitleText, string txtFirstNameText, string txtLastNameText)
        {
            bookService.AddBook(txtIsbnText, txtTitleText, txtFirstNameText, txtLastNameText);
            addBookView.Close();
            ClearAllBooks();
            LoadAllBooks();
        }

        public void SearchBooks(string isbn, string title, string firstName, string lastName)
        {
            var filteredBooks = bookService.SearchBooks(isbn, title, firstName, lastName);
            bookSearchView.Close();
            ClearAllBooks();
            LoadAllBooks(filteredBooks);
            bookView.EnableClear();
        }

        private void LoadAllBooks()
        {
            foreach (Book book in bookService.GetAllBooks())
            {
                bookView.AddBook(book);
            }
        }

        private void LoadAllBooks(List<Book> filteredBooks)
        {
            foreach (Book book in filteredBooks)
            {
                bookView.AddBook(book);
            }
        }

        private void ClearAllBooks()
        {
            bookView.ClearAllBooks();
        }


        public void ClearView()
        {
            ClearAllBooks();
            LoadAllBooks();
            bookView.DisableClear();
        }

        public Book GetBookByISBN(string name)
        {
          return  bookService.GetBookByISBN( name);
        }
    }
}