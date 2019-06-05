using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodsDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to perform math methods on.");
            int userNum = Convert.ToInt16(Console.ReadLine());

            MyMethods mathMethods = new MyMethods(); //Instantiates a MyMethods class
            int result = mathMethods.Square(userNum); //Calls a method of the instantiated MyMethods class
            Console.WriteLine("\nSquared: " + result);
            result = mathMethods.MultiplyByTen(userNum);
            Console.WriteLine("Multiplied by 10: " + result);
            ulong result2 = mathMethods.Factorial(userNum);
            Console.WriteLine("Factorial: " + result2);
            double half = mathMethods.HalfIt(userNum);
            Console.WriteLine("Halved: " + half);
            Console.Read();
        }
    }
}
