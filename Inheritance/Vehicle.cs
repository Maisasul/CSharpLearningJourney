using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Vehicle
    {
        public string name;
        public int id;
        public string descripion;
        protected Vehicle(string name, int id, string descripion)
        {
            this.name = name;
            this.id = id;
            this.descripion = descripion;
        }
    }

    interface Iload
    { 
        void Load();
        void unLoad();
    }

    interface IDrivoble
    {
        void move();
        void stop();
    }
    class honda : Vehicle, IDrivoble 
    {
        public int yearOF;
        public honda(string name, int id, string descripion, int yearOF) : base(name, id, descripion)
        {
            this.yearOF = yearOF;
        }
        public void move()
        {
            Console.WriteLine("MOVE!");
        }

        public void stop()
        {
            Console.WriteLine("STOP!");
        }
    }

    class track : Vehicle, Iload , IDrivoble
    {
        public track(string name, int id, string descripion) : base(name, id, descripion)
        {
        }
        public void move()
        {
            Console.WriteLine("MOVE!");
        }

        public void stop()
        {
            Console.WriteLine("STOP!");
        }

        public void Load()
        {
            Console.WriteLine("LOAD!");
        }

        public void unLoad()
        {
            Console.WriteLine("UNLODE!");
        }
    }
}
