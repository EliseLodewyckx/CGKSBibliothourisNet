using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliothouris.Forms;
using Bibliothouris.Forms.Members;
using Bibliothouris.Source.Books;

namespace Bibliothouris.Source.Rental
{
    public class RentalController
    {
        internal IRentalView rentalView { get; }
        internal BookController bookController { get; }
        internal MemberController memberController { get; }

        public RentalController(IRentalView rentalView, BookController bookController, MemberController memberController)
        {
            this.rentalView = rentalView;
            this.bookController = bookController;
            this.memberController = memberController;
            rentalView.SetController(this);
        }

        public void ShowBookList()
        {
            bookController.bookView.ShowDialog();
        }

        public void ShowMemberList()
        {
            memberController.view.ShowDialog();
        }

    }
}
