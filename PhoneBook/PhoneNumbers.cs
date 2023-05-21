using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class PhoneNumbers
    {
        public string[] Name;
        public string[] Number;
        public int Size;
        //public int count;

        public PhoneNumbers(int size)
        {
            this.Size = size;
            Name = new string[this.Size];
            Number = new string[this.Size];
        }
        //indexer, has no name, the name is the object of the class use "this"
        public string this[int index, string name]
        {
            set 
            { 
                Number[index] = value;
                Name[index] = name;
            }

            get
            {
                for (int i = 0; i < this.Size; i++) 
                {
                    if (Name[i] == name)
                    {
                        return Number[i];
                    }
                }
                return "NOT FOUND!";
            }
        }

       
        //public void setValue(int index, string name, string number)
        //{
          //  if (index > 0 && index < Size && index > count)
            //{
              //  this.Name[index] = name;
             //   this.Number[index] = number;
            //}
        //}

        //public string getValue(string name)
        //{
          //  for (int i = 0;i < this.Size;i++)
            //{
              //  if (Name[i] == name)
                //{
                  //  return this.Number[i];
               // }
           // }
            //return  "NOT FOUND!";
       // }
    }
}
