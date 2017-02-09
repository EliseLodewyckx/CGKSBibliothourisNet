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
    public interface IBookAddVIew
    {
        void SetController(BookController bookController);
        void Close();
        void Clear();
        DialogResult ShowDialog();
    }
    public partial class AddBooks : Form, IBookAddVIew
    {
        private Bookcontroller bookController;
        public AddBooks()
        {
            InitializeComponent();
        }

        public void SetController(BookController bookController)
        {
            this.bookController = bookController;
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            bookController.AddBooks(txtISBN.Text, txtTitle.Text, txtFirstName.Text, txtLastName.Text);
        }

        public void Clear()
        {
            txtISBN.Text = "";
            txtTitle.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
    }
}
