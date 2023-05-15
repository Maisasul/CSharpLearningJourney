using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_1
{
    public class Person
    {
        private string fname;
        private string lname;
        private int age;
        private double salary;
        private string rel;

        // get , set
        public string GetfName()
        { 
            return fname;
        }
        public void SetfName(string FirstName)
        {
            this.fname = FirstName;
        }
        public string GetlName()
        {
            return lname;
        }
        public void SetlName(string LastName)
        {
            this.lname = LastName;
        }
        public int Getage()
        {
            return age;
        }
        public void Setage(int Age)
        {
            this.age = 2023 - Age;
        }
        public double Getsalary()
        {
            return salary;
        }
        public void Setsalary(double Salary)
        {
            this.salary = Salary;
        }
        public string Getrel()
        {
            return rel;
        }
        public void Setrel(string relationship)
        {
            this.rel = relationship;
        }

        //public string printInfo()
        //{
        //    return $"hello mr  your name is {this.fname } {lname} ";
        //}
        public void printInfo()
        {
            Console.WriteLine($"hello mr  your name is {this.fname} {lname} ");
        }

        public int DataB(int a, int b)
        {
            return b - a;
        }
    }
}
