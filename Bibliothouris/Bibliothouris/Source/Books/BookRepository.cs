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


        public List<Book> getBookByISBN (string number)
        {    
           return books.Where<Book>(item => Regex.Matches(item.getISBN(), number).Count > 0).ToList<Book>();
        }

        public List<Book> getBookByTitle(string letters)
        {
            return books.Where<Book>(item => Regex.Matches(item.getTitle(), letters).Count > 0).ToList<Book>();
        }
        public List<Book> getBookByFirstNameAuthor(string name)
        {
            return books.Where<Book>(item => Regex.Matches(item.getAuthorFirstName(), name).Count > 0).ToList<Book>();
        }

        public List<Book> getBookByLastNameAuthor (string name)
        {
            return books.Where<Book>(item => Regex.Matches(item.getAuthorLastName(), name).Count > 0).ToList<Book>();
        }


        public List <Book> getAllBooks()
        {
            return this.books;
        }





    }
}
/*var qry = list
    .Where<string>(item => regEx.IsMatch(item))
    .ToList<string>();

 */
