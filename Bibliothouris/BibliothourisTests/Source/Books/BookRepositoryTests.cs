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
        Book book2 = new Book("another book", "8974561235987", "voornaam", "achternaam");
        Book book3 = new Book("bookbookbook", "6589254316874", "naampie", "pjespjes");

        [TestInitialize()]
        
        public void AddBooksToRepos()
        {
            
            bookrepos.AddBook(book1);
            bookrepos.AddBook(book2);
            bookrepos.AddBook(book3);
        }
        
      

        [TestMethod()]
        public void getBookByISBNTest()
        {
            List<Book> result = bookrepos.getBookByISBN("123");
            List<Book> expected = new List<Book> { book1, book2 };
            
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void getBookByTitleTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getBookByFirstNameAuthorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getBookByLastNameAuthorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetBookByAuthorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getAllBooksTest()
        {
            Assert.Fail();
        }
    }
}