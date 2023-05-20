namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Honda("Super", 2014, "Car");
            Honda honda = new Honda("Red", 2023, "Car");
            honda.Ready();
            honda.Start();
            honda.Stop();

            Caterpilar caterpilar = new Caterpilar("LALA", 1899, "Big");
            caterpilar.Ready();
            //  caterpilar.Load();

            ILoader loader = new Caterpilar("NO", 1999, "No");
            loader.Start();

        }
    }
}