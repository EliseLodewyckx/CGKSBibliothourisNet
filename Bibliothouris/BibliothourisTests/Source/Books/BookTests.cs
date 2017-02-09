using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bibliothouris.Source.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books.Tests {
    [TestClass()]
    public class BookTests {
        [TestMethod()]
        public void GetDetailsTest() {
            Book book = new Book("This is a book", "1589874565897", "iemand", "anders");
            string result = book.getDetails();
            string expected = "Title: This is a book\r\nISBN: 1589874565897\r\nAuthor: iemand anders";
            Assert.AreEqual(expected, result);
        }
    }
}