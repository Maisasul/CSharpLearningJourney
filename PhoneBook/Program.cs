namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneNumbers pn = new PhoneNumbers(5);
            pn[0, "Maisa"] = "1001";
            pn[1, "Amal"] = "2002";

            Console.WriteLine(pn[0, "Maisa"]);
            int[,] userInput = new int[,]
            {
                { 8, 3, 5, 4, 1, 6, 9, 2, 7 },
                { 2, 9, 6, 8, 5, 7, 4, 2, 3 },
                { 3, 4, 5, 6, 7, 8, 9, 2, 4 },
                { 4, 5, 6, 7, 9, 2, 3, 4, 5 },
                { 5, 6, 7, 9, 3, 4, 5, 6, 7 },
                { 5, 6, 7, 9, 4, 5, 6, 7, 4 },
                { 3, 5, 3, 1, 6, 7, 8, 4, 7 },
                { 7, 9, 8, 4, 2, 1, 4, 4, 5 },
                { 7, 8, 4, 2, 4, 7, 2, 6, 7 }
            };
            Sudoko s = new Sudoko(userInput);
            s[1, 2] = 13;
            Console.WriteLine(s[1, 2]);
        }
    }
}