using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class BookFunctios
    {
        public static string GetTitle(Book b)
            =>  b.Title;
        public static string GetAuthors(Book b) 
        {
            foreach (string a in b.Authors)
                Console.Write($"{a} ");
            return "";
        }
        public static decimal  GetPrice(Book b)
            => b.Price;
        public static Func<Book, string> GetISBN = delegate (Book b) { return b.ISBN; };
        public static Func<Book, DateTime> PublicationDate =  b =>{ return b.PublicationDate; };

    }
}
