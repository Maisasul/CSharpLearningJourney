using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavBook
{
    internal class Book
    {
        private string[] BookName;
        private string[] BookAuthor;
        private int length;

        public Book(int len) 
        {
            this.length = len;
            this.BookName = new string[length];
            this.BookAuthor = new string[length];
        }

        public string this[int indexer, string bookName]
        {
            get
            {
                string str = $"{bookName} : {BookAuthor[indexer]}";
                return str;
            }
            set 
            {
                BookName[indexer] = bookName;
                BookAuthor[indexer] = value;
            }
        }
    }
}
