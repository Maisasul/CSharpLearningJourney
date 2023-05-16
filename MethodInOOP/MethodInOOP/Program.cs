namespace MethodInOOP
{
    internal class Program
    {
        //add parameter, pass argument
        public static void PrintLine(int n, string pattren)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(pattren);
            }
            Console.WriteLine();
        }

        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void SumMul(int x, int y, out int S, out int M)
        {
            S = x + y;
            M = x * y;
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("first number");
            x = Convert.ToInt32(Console.ReadLine());
            PrintLine(10, "*");

            int a = 9, b = 6;
            Swap(ref a, ref b);
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");

            //call calculator class
            Calculator calculator = new Calculator();
            int w = 4, i = 5;
            double u = 1.2, d = 2.3;
            string e = "AB", c = "CD";
            Console.WriteLine(calculator.add(w,i));
            Console.WriteLine(calculator.add(u,d));
            Console.WriteLine(calculator.add(e,c));
            Console.WriteLine(calculator.isEven(w));

            //call person class
            Person person = new Person();
            person.name = "Maisa";
            person.age = 10;
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
        }
        
    }
}