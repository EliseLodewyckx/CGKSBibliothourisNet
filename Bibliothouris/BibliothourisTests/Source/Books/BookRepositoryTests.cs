using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibliothouris.Source.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books.Tests
{
    [TestClass()]
    public class BookRepositoryTests
    {
        BookRepository bookrepos = new BookRepository();
        Book book1 = new Book("this is a book", "1234567891011", "iemand", "achternaam");
        Book book2 = new Book("another book", "8974561235987", "voornaam", "achternaamaam");
        Book book3 = new Book("bookbookbook", "6589254316874", "naampie", "pjespjes");

        [TestInitialize()]

        public void AddBooksToRepos()
        {

            bookrepos.AddBook(book1);
            bookrepos.AddBook(book2);
            bookrepos.AddBook(book3);
        }



        [TestMethod()]
        public void GetBookByIsbnTest()
        {
            List<Book> result = bookrepos.getBookByISBN("123");
            List<Book> expected = new List<Book> { book1, book2 };
            List<Book> expected2 = new List<Book> { book1 };
            List<Book> result2 = bookrepos.getBookByISBN("1234567891011");

            CollectionAssert.AreEqual(expected, result);
            CollectionAssert.AreEqual(expected2, result2);
        }

        [TestMethod()]
        public void GetBookByTitleTest()
        {
            List<Book> result = bookrepos.getBookByTitle("another book");
            List<Book> expected = new List<Book> { book2 };
            List<Book> result2 = bookrepos.getBookByTitle("book");
            List<Book> expected2 = new List<Book> { book1, book2, book3 };

            CollectionAssert.AreEqual(expected, result);
            CollectionAssert.AreEqual(expected2, result2);

        }

        [TestMethod()]
        public void GetBookByFirstNameAuthorTest()
        {
            List<Book> result = bookrepos.getBookByFirstNameAuthor("iemand");
            List<Book> expected = new List<Book> { book1 };
            List<Book> result2 = bookrepos.getBookByFirstNameAuthor("naam");
            List<Book> expected2 = new List<Book> { book2, book3 };

            CollectionAssert.AreEqual(expected, result);
            CollectionAssert.AreEqual(expected2, result2);
        }

        [TestMethod()]
        public void GetBookByLastNameAuthorTest()
        {
            List<Book> result = bookrepos.getBookByLastNameAuthor("achternaam");
            List<Book> expected = new List<Book> { book1, book2 };
            List<Book> result2 = bookrepos.getBookByLastNameAuthor("pjes");
            List<Book> expected2 = new List<Book> { book3 };

            CollectionAssert.AreEqual(expected, result);
            CollectionAssert.AreEqual(expected2, result2);
        }

        [TestMethod()]
        public void GetBookByAuthorTest()
        {
            List<Book> result = bookrepos.GetBookByAuthor("iemand achternaam");
            List<Book> expected = new List<Book> { book1 };
            List<Book> result2 = bookrepos.GetBookByAuthor("naam achternaam");
            List<Book> expected2 = new List<Book> { book2 };

            CollectionAssert.AreEqual(expected, result);
            CollectionAssert.AreEqual(expected2, result2);
        }

        [TestMethod()]
        public void getAllBooksTest()
        {
            List<Book> result = bookrepos.getAllBooks();
            List<Book> expected = new List<Book> { book1, book2, book3 };

            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void ReturnDetailsOfAListOfBooksTest()
        {
            List<Book> searchedByISBN = bookrepos.getBookByISBN("123");
            string expected = "Title: this is a book\r\nISBN: 1234567891011\r\nAuthor: iemand achternaam\r\n\r\nTitle: another book\r\nISBN: 8974561235987\r\nAuthor: voornaam achternaamaam\r\n\r\n";
            string result = bookrepos.ReturnDetailsOfAListOfBooks(searchedByISBN);
            List<Book> searchedByISBN2 = bookrepos.getBookByISBN("1234567891011");
            string expected2 = "Title: this is a book\r\nISBN: 1234567891011\r\nAuthor: iemand achternaam\r\n\r\n";
            string result2 = bookrepos.ReturnDetailsOfAListOfBooks(searchedByISBN2);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected2, result2);

        }
    }
}

/*Book book1 = new Book("this is a book", "1234567891011", "iemand", "achternaam");
        Book book2 = new Book("another book", "8974561235987", "voornaam", "achternaamaam");
        Book book3 = new Book("bookbookbook", "6589254316874", "naampie", "pjespjes");
*/

/*       Book book = new Book("This is a book", "1589874565897", "iemand", "anders");
            string result = book.getDetails();
            string expected = "Title: This is a book\r\nISBN: 1589874565897\r\nAuthor: iemand anders";
            Assert.AreEqual(expected, result);
*/
