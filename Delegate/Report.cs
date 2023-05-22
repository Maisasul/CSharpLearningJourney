using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Report
    {
        //Delegate means that you would take a multiple signature for your Function if it represented for the Logic
        //            datatype name  className--> from what class 
        public delegate bool isValid(Empoleey e);

        //      take data from Employee[]      set title     
        public void CheckSalse(Empoleey[] emp, string title, isValid cond) //isVaid cond, write the condetion here
        {
            Console.WriteLine(title);
            Console.WriteLine("------------");
            foreach(Empoleey e in emp)
            {
                if(cond(e))
                {
                    Console.WriteLine($"{e.ID} {e.Name} {e.Gender} {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
