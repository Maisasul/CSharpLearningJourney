namespace Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array
            int[] arrS = new int [4]{ 1, 2, 3, 4 };
            Console.WriteLine(arrS);
            int[] arrS1 = { 1, 2, 3, 4 };
            string[] names = { "K", "Z", "Y" };
            Console.WriteLine(names[2]);

            //Mulit-Dimensional array
            int[,] arrm = new int[4,2] { { 3, 4 },{ 4, 5 },{ 5, 6 },{ 6, 8 } };
            Console.WriteLine(arrm);
            int[,] arrm1 = { { 3, 4 }, { 4, 5 }, { 5, 6 }, { 6, 8 } };

            //Jagged array
            int[][] arrj = new int[][]
                { new int[] {1,2,3,4},
                  new int[] {11,22,33,44},
                  new int[] {10,20,30,40}};
            Console.WriteLine(arrj);

            //Array Slicing
            int[] number = { 1, 2, 3, 4, 5, 6 };
            int[] slice = number[1..4];//slice 2,3,4
            Console.WriteLine(slice);
            int[] sliceB = number[2..^4];
            int[] slicet = number[..4];//start from index 0 to index 4 (1,2,3,4)
            int[] slicee = number[3..]; //start from index 3  to the end (4,5,6)
            int[] sliceq = number[..]; // whole array

            int x = 4;
            int y = 3;
            string result = (x % 2 == 0) ? "X is even" : "x is odd";
            Console.WriteLine(result);
            string result1 = (y % 2 != 0) ? "y is odd" : "y is even";
            Console.WriteLine(result1);

            //NULL
            int? z = null;
            string str = null;
            str = str ?? "Maisa";// ?? to check if null
            Console.WriteLine(str);
            string sr = null;
            Console.WriteLine(sr?.ToUpper());//? conditional null
            Console.WriteLine("---Block statment---");
            //Block statment
            int o = 3;
            {
                int i = 0;
                Console.WriteLine(i);
                Console.WriteLine(o);
            }
            //Console.WriteLine(i);// error, in {} stay in {}
            Console.WriteLine("---increamant & decreamant---");
            //increamant & decreamant
            int q = 1;
            Console.WriteLine(q++);
            Console.WriteLine(++q);
            //condition
            Console.WriteLine("---condition---");
            int finalPro = 87;
            int absence = 72;
            
        }
    }
}