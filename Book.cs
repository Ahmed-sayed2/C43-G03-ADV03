using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Book
    {
        
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors {get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicatiomDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicatiomDate;
            Price = _Price;

        }
        List<string> li=new List<string>();
        
        public override string ToString()
        {
            
            return $"ISBN={ISBN} Title={Title} Publication Date={PublicationDate} Price={Price} authors={BookFunctios.GetAuthors(this)} ";
        }
    }
}
