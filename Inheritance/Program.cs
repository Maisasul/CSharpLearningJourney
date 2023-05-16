namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cat class 
            Console.WriteLine("---cat class---");
            Cat cat = new Cat();
            cat.name = "tome";
            cat.age = 2;
            cat.gender = "Female";
            Console.WriteLine(cat.name);
            Console.WriteLine(cat.age);
            Console.WriteLine(cat.gender);
            cat.move();
            cat.soud();
            cat.makeSound();
            Console.WriteLine(cat);//show the override mothed  ToString

            // dog calss
            Console.WriteLine("---dog class---");
            Dog dog = new Dog();
            dog.name = "Sam";
            dog.age = 4;
            dog.category = "dog";
            Console.WriteLine(dog.name);
            Console.WriteLine(dog.age);
            Console.WriteLine(dog.category);
            dog.move();
            dog.soud();
            dog.makeSound();

            //Eagle class
            Console.WriteLine("---eagle class---");
            Eagle eagle = new Eagle();
            eagle.name = "sd";
            eagle.age = 2;
            eagle.gender = "Male";
            Console.WriteLine(eagle.name);
            Console.WriteLine(eagle.age);
            Console.WriteLine(eagle.gender);
            eagle.move();
            eagle.flay();
            eagle.makeSound();

            //Vehicle 
            
        }
    }
}