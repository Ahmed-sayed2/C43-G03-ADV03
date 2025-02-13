namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
           Book b=new Book("aa", "BB",["as","sdsa"],new DateTime(01/22/2001),205);
            Console.WriteLine(b);
            List<Book> list=new List<Book>();
            list.Add(b);
            list.Add(new Book("aa", "BB1", ["as", "sdsa"], new DateTime(01 / 22 / 2001), 205));
            list.Add(new Book("aa", "BB2", ["as", "sdsa"], new DateTime(01 / 22 / 2001), 205));
            
            Func<Book, string> f = BookFunctios.GetTitle;
            LibraryEngine.ProcessBook(list,f);
            Console.WriteLine( BookFunctios.GetISBN(b));
        }
    }
}
