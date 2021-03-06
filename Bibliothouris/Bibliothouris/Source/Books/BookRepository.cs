﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bibliothouris.Source.Books
{
   public class BookRepository
    { private List<Book> books = new List<Book>();


        public List<Book> getBooksByDetails(string number, string title, string firstName, string lastName)
        {
            

            /*number =  number.Replace("*", ".*");
            title = title.Replace("*", ".*");
            firstName =  firstName.Replace("*", ".*");
            lastName = lastName.Replace("*", ".*");*/
            return books.Where<Book>(item =>RegexWithWildcard(number).Matches(item.getISBN()).Count > 0)
                .Where<Book>(item => RegexWithWildcard(title).Matches(item.getTitle()).Count > 0)
                .Where<Book>(item => RegexWithWildcard(firstName).Matches(item.getAuthorFirstName()).Count > 0)
                .Where<Book>(item => RegexWithWildcard(lastName).Matches(item.getAuthorLastName()).Count > 0).ToList<Book>();
        }

        public Regex RegexWithWildcard(string input)
        {
            string pattern = input.Replace("*", ".*");
            return new Regex(pattern);

        }

        public List <Book> getAllBooks()
        {
            return this.books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public string ReturnDetailsOfAListOfBooks(List<Book> bookList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Book b in bookList)
            {
                sb.Append(b.getDetails());
                sb.Append("\r\n\r\n");
            }
            return sb.ToString();
        }




    }
}

