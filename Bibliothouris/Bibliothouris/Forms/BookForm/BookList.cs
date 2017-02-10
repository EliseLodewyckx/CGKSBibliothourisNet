using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.Books;

namespace Bibliothouris.Forms.BookForm
{
    public interface IBookView
    {
        void SetController(BookController bookcontroller);
        void AddBook(Book book);
        void ClearAllBooks();
        void EnableClear();
        void DisableClear();
        DialogResult ShowDialog();
    }

    public partial class BookList : Form, IBookView
    {
        private BookController bookcontroller;

        public BookList()
        {
            InitializeComponent();
        }

        public void SetController(BookController bookcontroller)
        {
            this.bookcontroller = bookcontroller;
        }

        public void AddBook(Book book)
        {
            bookListView.Items.Add(CreateBookListViewItem(book));
        }

        private ListViewItem CreateBookListViewItem(Book book)
        {
            ListViewItem bookItem = new ListViewItem(book.getISBN());
            bookItem.SubItems.Add(book.getTitle());
            bookItem.SubItems.Add(book.getAuthorFullName());
            return bookItem;
        }

        public void ClearAllBooks()
        {
            bookListView.Items.Clear();
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {
            bookcontroller.ShowAddBook();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            bookcontroller.ClearView();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            bookcontroller.SearchBookView();
        }

        public void EnableClear()
        {
            btClear.Visible = true;
        }

        public void DisableClear()
        {
            btClear.Visible = false;
        }


        private void bookListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var book = bookcontroller.GetBookByISBN(bookListView.SelectedItems[0].Name);
            MessageBox.Show(String.Format("book:ISBN: {0} \r\n Title: {1} \r\n Author: {2}", book.getTitle(), book.getISBN(), book.getAuthorFullName()));
        }

  
    }
}