using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Bibliothouris.Source.Books
{
    public class Book
    {
        string title;
        string ISBN;
        string AuthorFirstName;
        string AuthorLastName;

       

            public Book (string title, string ISBN, string AuthorFirstName, string AuthorLastName) {
            this.title = title;
            this.ISBN = ISBN;
            this.AuthorFirstName = AuthorFirstName;
            this.AuthorLastName = AuthorLastName;
        }

        public string getTitle() {
            return title;
        }

        public string getISBN () {
            return ISBN;
        }

        public string getAuthorFirstName() {
            return AuthorFirstName;
        }

        public string getAuthorLastName() {
            return AuthorLastName;
        }

        public string getDetails () {
            StringBuilder sb = new StringBuilder();
            sb.Append("Title: " + getTitle() + "\r\n");
            sb.Append("ISBN: " + getISBN() + "\r\n");
            sb.Append("Author: " + getAuthorFirstName() + " " + getAuthorLastName());

            return sb.ToString();
        }

        }
    }

