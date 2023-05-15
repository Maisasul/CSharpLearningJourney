using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace ClassSession
{
    //public class Employee
    //{
      //  public const double TAX = 0.03; 
      //  public string firstName;
     //   public string lastName;
    //    public double wage;
     //   public double loggeHour;
   // } 
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee();
            
            /*employee.firstName = "Maisa";
            employee.lastName = "Sul";
            employee.wage = 5;
            employee.loggeHour = 10;*/

            Console.WriteLine("Enter number of employee : "); //for loop run based on user input
            int munOfEmp = Convert.ToInt32(Console.ReadLine());
            //int[] emps  = new Employee(munOfEmp);
            for (int i = 0; i <= munOfEmp; i++)
            {
            Console.WriteLine($"Enter Your Full name:");
            String firstName = Console.ReadLine();
            Console.WriteLine($"Enter the wage:");
            double wage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Enter the logged Hours:");
            double loggeHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your Full name:{employee.firstName} {employee.lastName}");
            // calculation
            double totalSalary = employee.loggeHour * employee.wage;
            double taxRate = totalSalary * Employee.TAX;
            double netSalary = totalSalary - taxRate;

            // user output of calculaton
            Console.WriteLine($"Total salary: {totalSalary}");
            Console.WriteLine($"Tax Rate: {taxRate}");
            Console.WriteLine($"Net Salary: {netSalary}");



            }
            
        }
    }
}