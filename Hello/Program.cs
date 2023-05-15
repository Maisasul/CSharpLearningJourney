namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is single comment
            /*
             this is multi comment
             */

            Console.WriteLine("Hi! I am Maisa Al-Hashmi this is my first code in C# " +
                "in Makeen bootcampe in code Academy and this is just the start");
            //string concatination
            String name = "Maisa";
            int age = 25;
            Console.WriteLine(name);
            Console.WriteLine(age);
            //regular Concation
            Console.WriteLine("Your name is "+name+" you are "+age+" years old");
            //string intepolation
            Console.WriteLine($"Your name is {name} you are {age} years old");
            
            int a = 2, b = 4;
            Object o1 = new Object();
            Object o2 = new Object();
            Console.WriteLine(o1.GetHashCode()); 
            Console.WriteLine(o2.GetHashCode());
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(a.GetType());
            Console.WriteLine(o1.GetType());

            var x = "BB";
            //x = 3;
            dynamic c = "kk";
            c = 4;

            //Comparison operater
            int m = 23;
            int n = 67;
            bool equl = m == n; //false
            bool notequle = m != n; //True
            bool graterthan = m > n; //False
            bool lessthan = m < n; //True
            bool graterthanorequle = m >= n; //False
            bool lessthanorequle = m <= n; //True

            // xor operater
            bool w = true;
            bool e = false;
            bool r;
            r = w ^ e;
            Console.WriteLine(true ^ false); //true
            Console.WriteLine(true ^ true); //false
            Console.WriteLine(false ^ false); //false
            Console.WriteLine(false ^ true); //true
        }
    }
}