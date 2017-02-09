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
{
    public partial class BookList : Form
    {
        public interface IBookView {
            void SetController(BookController bookcontroller);
            void AddBook(Book book);
            void ClearAllBooks();
            DialogResult ShowDialog();

        }
        public partial class Booklist : Form,IBookView
        {
            private BookController bookcontroller;
            public Booklist()
            {
                InitializeComponent();
            }
            public void SetController (BookController bookController)
            {
                this.bookcontroller = bookcontroller;
            }
            public void AddBooks (Book book)
            {
                bookListView.Items.Add(CreateBookListViewItem(book));
            }
        }

        /*
          
            private ListViewItem CreateUserListViewItem(User user)
            {
                ListViewItem userItem = new ListViewItem(user.ID.ToString());
                userItem.SubItems.Add(user.Name);
                return userItem;

            }

            public void ClearAllUsers()
            {
                userListView.Items.Clear();
            }

            private void add_Click(object sender, EventArgs e)
            {
                userController.addUserView();
            }

        }*
         */
        public BookList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string author = txtSearchByAuthor.Text;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string isbn = txtSearchByIsbn.Text;


        }

        private void txtSearchByTitle_TextChanged(object sender, EventArgs e)
        {
            string title = txtSearchByTitle.Text;
        }
    }
}