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
{ public interface IBookSearchView
    {
        void SetController(BookController bookController);
        void Close();
        void CLear();
        DialogResult ShowDialog();
    }
    public partial class SearchBooks : Form, IBookSearchView
    {
        private BookController bookController;
        public SearchBooks()
        {
            InitializeComponent();
        }
        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            bookController.SearchBooks(txtSearchISBN.Text);
            bookController.SearchBooks(txtSearchTitle.Text);
            bookController.SearchBooks(txtSearchFirstName.Text);
            bookController.SearchBooks(txtSearchLastName.Text);
        }
        public void Clear()
        {
            txtSearchISBN.Text = "";
            txtSearchTitle.Text = "";
            txtSearchFirstName.Text = "";
            txtSearchLastName.Text = "";
        }
    }
}
