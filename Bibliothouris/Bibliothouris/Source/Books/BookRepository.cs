using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
   public class BookRepository
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
        public List<Book> GetBookByAuthor (string name)
        {
            return books.Where<Book>(item => Regex.Matches(item.getAuthorFirstName() + item.getAuthorLastName(), name).Count > 0).ToList<Book>();
        }


        public List <Book> getAllBooks()
        {
            return this.books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }




    }
}
/*var qry = list
    .Where<string>(item => regEx.IsMatch(item))
    .ToList<string>();

 */
