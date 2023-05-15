using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Employee
    {
        public const double TAX = 0.03;
        public string firstName;
        public string lastName;
        public double loggerdHours;
        public double wage;

        //Method Syntax (simple)
        //public
        //<Access Modifier > <Datatype> / Void  Method Name (Parameters)
        /*
            {
                series of Statments
        }             

         */
        public void DoSomething()
        {
            Console.WriteLine($" HELLO employee ");
        }
        public int Dothing()
        {
            int x = 100;
            return x * x;
        }
    }
}
