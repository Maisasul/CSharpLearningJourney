using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem
{
    internal class DAYINWEE
    {
        int day;
        //enum day
        //{
        //  Sunday = 1,
        //Monday,
        //Tuesday,
        //Wednesday,
        //  Thursday,
        //  Friday,
        // Saturday,
        // weekend = Friday & Saturday
        // }

        public string BookAppointment()
        {
            int day;
            Console.WriteLine("Please choose a day?");
            int dayChoose = Convert.ToInt32(Console.ReadLine());
            
            if (dayChoose == 6 || dayChoose == 7)
            {
                Console.WriteLine("It's weekend! no appointment. Please choose another day");
            }
            else if (dayChoose <= 5 && dayChoose >= 1)
            {
                Console.WriteLine($"Day selected is {this.day}");
                Console.WriteLine("Your Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Relationship Status: ");
                string relationship = Console.ReadLine();
                Console.WriteLine("First visit? ");
                string visit = Console.ReadLine();
                Console.WriteLine("Confirmation reservation details:- ");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Relationship Status: {relationship}");
                Console.WriteLine($"First visit: { visit}");
                Console.WriteLine($"appointment day: {this.day}");
            }
            switch (this.day)
            {
                case 1:
                    //Console.WriteLine("Sunday"); 
                    return"Sunday";
                    break;
                case 2:
                    return "Monday";
                    break;
                case 3:
                    return "Tuesday";
                    break;
                case 4:
                    return "Wednesday";
                    break;
                case 5:
                    return "Thursday";
                    break;
                case 6:
                    return "Friday";
                    break;
                case 7:
                    return "Saturday";
                    break;
                default:
                    return "NO DAY";
                    break;
            }
        }
    }
}
