using System;
using System.Collections.Generic;
using System.Text;
using working11.Enum;

namespace working11.Models
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }

        public Genre Genre { get; set; }

        public Book(string name, string authot, int pagecount, Genre genre)
        {
            Name = name;
            Author = authot;
            PageCount = pagecount;
            Genre = genre;
        }
        public override string ToString()
        {
            return $" Name: {Name}\n Author: {Author}\n Page Count: {PageCount}\n Genre: {Genre}";
        }
    }
}
