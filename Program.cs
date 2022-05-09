using System;
using working11.Enum;
using working11.Interface;
using working11.Models;
using working11.Service;

namespace working11
{
    class Program
    {
        static void Main(string[] args)
        {
            librarymanager Librarymeneger = new librarymanager();

            Librarymeneger._books.Add(new Book("Seid", "Zahidov", 12, Genre.drama));

            foreach (var item in Librarymeneger._books)
            {
                Console.WriteLine(item);
            }
        }
    }
}
