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
        private BookService service;

        public BookController(BookService service)
        {
            this.service = service;
        }
    }
}
