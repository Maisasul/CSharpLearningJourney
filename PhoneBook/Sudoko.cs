using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Sudoko
    {
        private int[,] Matrix;
        public Sudoko(int[,] matrix) 
        {
            this.Matrix = matrix;
        }

        public int this[int row, int col]
        {
            get 
            {
                return Matrix[row, col];
            }
            set 
            {
                Matrix[row, col] = value;   
            }
        }
    }
}
