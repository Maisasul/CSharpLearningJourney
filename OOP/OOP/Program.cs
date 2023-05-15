namespace OOP
{
    //creat class for employee
    /*public class Employee
    {
        public const double TAX = 0.03;
        public string firstName;
        public string lastName;
        public double loggerdHours;
        public double wage;

    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*const double TAX = 0.03;
            string firstName;
            string lastName;
            double loggerdHours;
            double wage;*/

            // get the data from the user
            Console.WriteLine("How many employee? ");
            int numEmployee = Convert.ToInt32(Console.ReadLine());
            int[] EmployeeNumber = new int[numEmployee];

            foreach (int i in EmployeeNumber) 
            {
                Employee employee = new Employee();

                Console.WriteLine("Your first name? ");
                employee.firstName = Console.ReadLine();

                Console.WriteLine("Your last name? ");
                employee.lastName = Console.ReadLine();

                Console.WriteLine("Logged hours? ");
                employee.loggerdHours = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wage? ");
                employee.wage = Convert.ToDouble(Console.ReadLine());

                double totaleSalary = employee.loggerdHours * employee.wage;
                double taxRate = totaleSalary * Employee.TAX;
                double netSalary = totaleSalary - taxRate;
                Console.WriteLine($"Full name: {employee.firstName} {employee.lastName}");
                Console.WriteLine($"Totale Salary: {totaleSalary}");
                Console.WriteLine($"Tax Rate: {taxRate}");
                Console.WriteLine($"Net Salary: {netSalary}");

            }

        }
    }
}