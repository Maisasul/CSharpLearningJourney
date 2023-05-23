namespace MultiCastDelegate
{
    internal class Program
    {
        public delegate void RectangleDel(double width, double height);
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
                                                        // subscription
            RectangleDel rectangleDel = new RectangleDel(rect.GetArea);
            rectangleDel += rect.GetPerimeter;// subscription
            rectangleDel -= rect.Add; // UnS  ubscription
            rectangleDel(42, 24);
            
        }
    }
    class Rectangle
    {
        public double width { get; set; }
        public double height { get; set; }

        public void GetArea(double width, double height)
        {
            Console.WriteLine($"Area = {width * height}");
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine($"Perimeter = {2 * (width + height)}");
        }
        public void Add(double width, double height)
        {
            Console.WriteLine($"Add = {width + height}");
        }
        public void Subtraction(double width, double height)
        {
            Console.WriteLine($"Subtraction = {width - height}");
        }
        public void Division(double width, double height)
        {
            Console.WriteLine($"Division = ${width / height}");
        }
    }
}