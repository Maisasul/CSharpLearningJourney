using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodInOOP
{
    internal class Calculator
    {
        public int add(int x, int y) => x + y;

        public double add(double z, double n) => z + n;

        public string add(string m, string l) => m + l;

        public string isEven(int v) => (v % 2 == 0) ? "even" : "odd";
    }
}
