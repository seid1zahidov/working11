using System;
using System.Collections.Generic;
using System.Text;
using working11.Models;
using working11.Interface;
using working11.Enum;

namespace working11.Service
{
    class librarymanager
    {
        public List<Book> _books { get; }

        public librarymanager()
        {
            _books = new List<Book>();
        }

        public Book Add(Book book)
        {
            if (_books.Count < 0 || _books.Exists(b => b.Name.ToLower() == book.Name.ToLower()))
            {
                throw new Exception("duzgun deil");
            }
            return book;
        }

        public List<Book> Search(string value)
        {
            List<Book> book = _books.FindAll(b => b.Name.ToLower() == value.ToLower() || b.Author.ToLower() == value.ToLower());
            return _books;
        }

        public List<Book> Filter(string author, Genre genre)
        {
            List<Book> books = _books.FindAll(b => b.Name.ToLower() == author.ToLower() || b.Genre.ToString() == genre.ToString());
            return _books;
        }
        public Book ShowInfo(string value)
        {
            Book bOok = _books.Find(b => b.Name.ToLower() == value.ToLower());
            if (bOok == null)
            {
                throw new Exception("duzgun doyul");
            }
            return bOok;

        }
    }
}
