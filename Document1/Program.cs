using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Threading.Channels;

namespace Document1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we use Console.WriteLine to print output,
            //Console.WriteLine print a new line after the value or text
            Console.WriteLine("Hello, World!");

            //Console.Write print the value or text without new line
            Console.Write("Hello, World!");

            // Comments are used to explain the code, we have to types of comments:
            //this is single line comment

            /*
             * this is multiple line comments 
             */

            //Variables, used to store the value or data
            //types of varibles
            int num = 1;//number
            string text = "Your work matters";//text, use double quotation
            double db = 3.453;//number with decimal point
            float ff = 0.0f;//number with decimal point
            bool tf = false;// true or false

            //declaration variable (datatype name_of_variable)
            int homeUnm;
            string life;
            //assignment a value
            homeUnm = 3010;
            life = "good";
            Console.WriteLine($"Your home number is {homeUnm}");
            Console.WriteLine(life);

            //new, is like we create a child from parent
            Object ob;//declare object
            ob = new Object();//allocate in memory
            ob.GetType();//return object type
            ob.GetHashCode();//return object identity

            //String concatenation it means combining strings together
            //(add string to end of other string),we have two types
            string carName = "mazda";
            string carColor = "red";
            //regular concatenation, use plus sign
            Console.WriteLine("Is there a "+carColor+" color in "+carName+" cars?");
            //String interpolation
            Console.WriteLine($"Is there a {carColor} color in {carName} cars");

            //var and dynamic, used for automatic detection for the Variable Data tpye
            //var, type of the variable is determined at compile time
            var k = "will";// and cannot be changed later
            dynamic d = 2;//type of the variable is determined at runtime
            d = "d2"; //and can changed later

            /*Expression, combination of one or more values, variables, 
             * operators, and function calls 
             * that can be evaluated to produce a result
            */
            int e = 2 * 4;//(+ - / *)

            /*Comparison Operators
             * compare two values
             * return Boolen value(True, Flase)
            */
            int t = 2;
            int f = 7;
            bool equal = t == f;//false
            Console.WriteLine(t==f);
            bool notEqual = t != f;//true
            Console.WriteLine(notEqual);
            bool graterThan = t > f;//false
            bool graaterThanOrEqual = t >= f;// false
            bool lessThan = t < f;//true
            bool lessThanOrEqual = t <= f;//true

            /*Logical Operators
             * used for combining two or more relational statements
            */
            bool tb = true;
            bool fb = false;
            int ti = 10;
            int fi = 20;
            //AND operators(&&) --> T && T = T, others F
            bool and = tb && fb;//false
            bool and1 = (ti < fi) || (ti != fi);//true
            //OR operators(||) --> F || F = F, others T
            bool or = tb || fb;//true
            bool or1 = (ti > fi) || (ti == fi);//false
            //NOT operators(!) --> !T = F, !F = T
            bool not = !tb;//false
            bool not1 = !(ti == fi);//True
            //XOR operators(^) --> T ^ T = F, F ^ T = T, F ^ F = T, T ^ F = T
            bool xor = tb ^ fb;//true
        }
    }
}