using System;
using System.Collections.Generic;
using System.Text;
using working11.Models;

namespace working11.Interface
{
    class ILibraryManager
    {
        static List<Book> books;
        static ILibraryManager()
        {
            books = new List<Book>();
        }
    }
}
