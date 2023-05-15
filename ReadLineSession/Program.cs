using System.Formats.Asn1;

namespace ReadLineSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert
            string str = "9876";
            int number1 = int.Parse(str);
            int number2 = Convert.ToInt32(str);
            int number3 = int.TryParse(str, out int number4) ? number4:0;


            //const
            const double PI = 3.14;
            Console.WriteLine("Area(1) or circunference(2)");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter r ");
            double r = Convert.ToDouble(Console.ReadLine());
            switch (c)
            {
                case 1:
                    double circunference = 2 * PI * r;
                    Console.WriteLine("circunference =" + circunference);
                    break;
                case 2:
                    double area = PI * Math.Pow(r, 2);
                    Console.WriteLine("Area = " + area);
                    break;
                default: 
                    Console.WriteLine();
                    break;
            }



            //ReadLine() to grt data from the user
            Console.WriteLine("enter student number:");
            string userinput = Console.ReadLine();
            int numStd;
            numStd = Convert.ToInt32(userinput);
            //int[] arrGrade = new int[numStd];
            for (int i = 0; i < numStd; i++) 
            {
                Console.WriteLine("enter student mark ");
                string inMark = Console.ReadLine();
                int mark;
                mark = Convert.ToInt32(inMark);
                if (mark >= 90 && mark <= 100)
                {
                    Console.WriteLine("A");
                }
                else if (mark >= 80 && mark < 90)
                {
                    Console.WriteLine("B");
                }
                else if (mark >= 70 && mark <= 79)
                {
                    Console.WriteLine("C");
                }
                else if (mark >= 60 && mark <= 69)
                {
                    Console.WriteLine("D");
                }
                else if(mark <= 59)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine("Invalid data!");
                }
            }

            
        }
    }
}