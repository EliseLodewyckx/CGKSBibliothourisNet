using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliothouris.Source.User;
using Bibliothouris.Forms;
using Bibliothouris.Forms.BookForm;
using Bibliothouris.Forms.MemberForms;
using Bibliothouris.Forms.Members;
using Bibliothouris.Source.Books;
using Bibliothouris.Source.Rental;

namespace Bibliothouris
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /* UserController userController = new UserController(new UsersForm(), new UserAddForm(), new UserService());
             userController.view.ShowDialog();    */
            //        MemberController memberController = new MemberController(new MembersForm(), new MemberAddForm(), new MemberService());
            //            memberController.view.ShowDialog();

            RentalController rentalController = new RentalController(new RentalView(),
                new BookController(new AddBooks(), new SearchBooks(), new BookService(new BookRepository()), new BookList()),
                new MemberController(new MembersForm(), new MemberAddForm(), new MemberService()));
            rentalController.rentalView.ShowDialog();
        }
    }
}