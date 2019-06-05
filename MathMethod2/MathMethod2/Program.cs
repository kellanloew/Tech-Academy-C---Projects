using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod2
{
    class Program
    {
        static void Main()
        {
            MathOperation MathMethod = new MathOperation(); //Instantiates the class MathOperation
            MathMethod.Exponent(5, 4); //Calls the exponent method of that class
            MathMethod.Exponent(power: 4, input: 5); //Calls the exponent method of that class
            Console.Read();
        }
    }
}
