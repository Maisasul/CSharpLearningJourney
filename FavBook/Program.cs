namespace FavBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(6);
            book[1, "Life is hard"] = "Amal";
            book[2, "Deep space"] = "Maisa";
            book[3, "Programer Brain"] = "Fatma";
            Console.WriteLine(book[1,"Life is hard"]);
            Console.WriteLine(book[2,"Deep space"]);
            Console.WriteLine(book[3,"Programer Brain"]);
        }
    }
}