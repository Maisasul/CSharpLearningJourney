using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     abstract class Animal //parent class, abstract ==> can't creat object for this class  
    {
        public string name;
        public int age;
        public virtual void move() //virtual to do override
        {
            Console.WriteLine("this anamil can move");
        }

        public abstract void makeSound();//abstract method
    }

    class Cat : Animal
    {
        public string gender;
        public void soud() 
        {
            Console.WriteLine("cat has sound meaow");
        }
        public override void move() //virtual, this methoduse to change the behavior of class
        {
            base.move();// to change the behavior 
            Console.WriteLine("cat has 4 legs");
        }
        public override void makeSound() 
        {
            Console.WriteLine("meaow meaow meaow");
        }

        public override string ToString()//override ToSting 
        {
            return $" my name is {this.name}";
        }
    }

    class Dog : Animal
    {
        public string category;
        public void soud()
        {
            Console.WriteLine("Dog has sound woof");
        }
        public override void makeSound() 
        {
            Console.WriteLine("woof woof woof");
        } 
    }

    sealed class Eagle : Animal // sealed ==> use to to be not inheritance
    {
        public string gender;
        public void flay() 
        {
            Console.WriteLine("bird can flay");
        }
        public override void makeSound()
        {
            Console.WriteLine("ta ta ta");
        }
    }
}
