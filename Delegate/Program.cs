namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Empoleey[] emps = new Empoleey[]
            {
                new Empoleey { ID = 1, Name = "Maisa", Gender = 'F', TotalSales = 87000m },
                new Empoleey { ID = 2, Name = "Amal", Gender = 'F', TotalSales = 77000m },
                new Empoleey { ID = 3, Name = "Sara", Gender = 'F', TotalSales = 56000m },
                new Empoleey { ID = 4, Name = "Ahmed", Gender = 'M', TotalSales = 45000m },
                new Empoleey { ID = 5, Name = "Ali", Gender = 'M', TotalSales = 23000m },
                new Empoleey { ID = 6, Name = "Sul", Gender = 'M', TotalSales = 21000m },
            };
            Report report = new Report();
            report.CheckSalse(emps, "Total salse more than 60k", (emp) => emp.TotalSales >= 60000);
            report.CheckSalse(emps, "Total salse btween 30k to 60k", (emp) => emp.TotalSales >= 30000 && emp.TotalSales <= 60000);
            report.CheckSalse(emps, "Total salse less than 30k", (emp) => emp.TotalSales < 30000);

        }
    }
}