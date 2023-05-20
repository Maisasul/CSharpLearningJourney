using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Vehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }

        public Vehicle(string Model, int Year, string Category) 
        {
            this.Model = Model;
            this.Year = Year;
            this.Category = Category;
        }
    }

    interface IDrivoble
    {
        void Ready();
        void Start();
        void Stop();
    }

    interface ILoader
    {
        void Load();
        void UnLoad();
        void Start();
    }

    class Honda : Vehicle, IDrivoble
    {
        public Honda(string Model, int Year, string Category) : base(Model, Year, Category)
        {
        }
        
        public void Ready() 
        {
            Console.WriteLine("Ready To Move!");
        }

        public void Start() 
        {
            Console.WriteLine("Start Honda");
        }

        public void Stop() 
        {
            Console.WriteLine("Stop Honda");
        }
    }

    class Caterpilar : Vehicle, IDrivoble, ILoader
    {
        public Caterpilar(string Model, int Year, string Category) : base (Model, Year, Category) 
        {
        }

        void ILoader.Start()
        {
            Console.WriteLine("Start Loading");
        }
        void ILoader.Load() 
        {
            Console.WriteLine("Loading..");
        }
        void ILoader.UnLoad() 
        {
            Console.WriteLine("UnLoad..");
        }
        
        void IDrivoble.Start() 
        {
            Console.WriteLine("Start Your Caterpilar");
        }
        public void Ready() 
        {
            Console.WriteLine("Get Ready");
        }
        void IDrivoble.Stop() 
        {
            Console.WriteLine("STOP!!!");
        }
      
    }
}
