using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;

namespace ClinicSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DAYINWEE dAYINWEE = new DAYINWEE();
            Console.WriteLine("Welcome to the Clinic Reservation System!");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1- Book an appointment.");
            Console.WriteLine("2- Update an appointment.");
            int mune = Convert.ToInt32(Console.ReadLine());
            switch (mune)
            {
                case 1:
                    dAYINWEE.BookAppointment();
                    break;
                case 2:
                    Console.WriteLine("Update");
                    break;
                default:
                    Console.WriteLine("Invalid Option, TRY AGAIN!");
                    break;
            }
        }        
    }
}