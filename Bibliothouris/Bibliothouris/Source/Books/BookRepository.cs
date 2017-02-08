using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
    class BookRepository
    { private List<Book> books = new List<Book>();


        public List<Book> getBookByISBN (string isbn)
        {
            List<Book> Isbn = new List<Book>();
            isbn = isbn.R
            var numbers = isbn.Where<Book>(item => Regex.Matches(item.ISBN, isbn)).ToList<Book>;
            return numbers;
            

        }







    }
}
/*var qry = list
    .Where<string>(item => regEx.IsMatch(item))
    .ToList<string>();

 */
