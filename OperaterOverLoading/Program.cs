using System.Security.Cryptography.X509Certificates;

namespace OperatorOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operator Over Loading");
            Box box1 = new Box(8);
            Box box2 = new Box(2);
            Box box3 = box1 + box2;
            Box box4 = box1 - box2;
            Box box5 = box1 / box2;
            Box box6 = box1 * box2;
            Console.WriteLine($"+ Operator {box3.waight}");
            Console.WriteLine($"- Operator {box4.waight}");
            Console.WriteLine($"/ Operator {box5.waight}");
            Console.WriteLine($"* Operator {box6.waight}");
        }
    }
    class Box
    {
        public decimal waight { get; set; }

        public Box(decimal waight)
        {
            this.waight = waight;
        }
        public static Box operator +(Box a, Box b)
        {
            decimal c = a.waight + b.waight;
            return new Box(c);
        }
        public static Box operator -(Box a, Box b) 
        {
            decimal c = a.waight - b.waight;
            return new Box(c);
        }
        public static Box operator /(Box a, Box b)
        {
            decimal c = a.waight / b.waight;
            return new Box(c);
        }
        public static Box operator *(Box a, Box b)
        {
            decimal c = a.waight * b.waight;
            return new Box(c);
        }
        public static Box operator ==(Box a, Box b)
        {
            if (a.waight == b.waight)
                return a;
            return false;
        }
    }

}