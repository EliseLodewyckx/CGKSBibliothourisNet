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
using Bibliothouris.Source.Rental;

namespace Bibliothouris.Forms
{
    public interface IRentalView
    {
        void SetController(RentalController rentalController);
        DialogResult ShowDialog();
    }
    public partial class RentalView : Form, IRentalView
    {
        private RentalController rentalController;
        public RentalView()
        {
            InitializeComponent();
        }

        private void memberBtn_Click(object sender, EventArgs e)
        {
            rentalController.ShowMemberList();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            rentalController.ShowBookList();
        }
        public void SetController(RentalController rentalController)
        {
            this.rentalController = rentalController;
        }
    }
}
