using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliothouris.Forms.BookForm
{ public interface IBookView
    {
        void SetController(BookController bookcontroller);
        void AddBook(Book book);
        void ClearAllBooks();
        DialogResult ShowDialog();
    }
    public partial class BookList : Form , IBookView
    {
        private BookController bookcontroller;
        
        public BookList()
        {
            InitializeComponent();
        }
        public void SetController (BookController bookcontroller)
        {
            this.bookcontroller = bookcontroller;
        }
        public void Adduser (Book book)
        {
            bookListView.Items.Add(CreateBookListViewItem(book));
        }
        private BookviewItem CreateBookListViewItem(Book book)
        {
            BookViewItem bookItem = new BookViewItem(book.ISBN);
            bookItem.SubItems.Add(book.ISBN);
            bookItem.SubItems.Add(book.Title);
            bookItem.SubItems.Add(book.Author);
        }
        public void ClearAllUsers()
        {
            userListView.Items.Clear();
        }
   
    }
}
