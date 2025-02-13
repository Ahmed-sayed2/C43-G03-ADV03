using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class LibraryEngine
    {
        public static void ProcessBook(List<Book> blist,Func<Book,string> fptr )
        { 
            foreach(Book book in blist)
            {
                Console.WriteLine($"{fptr(book)}");
            }
        
        }
    }
}
