using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodsDrill
{
    public class MyMethods //Defines class composed of math methods
    {
        public int Square(int input)//Squaring method. We specify return parameter type. Just like a regular function
        {
            int output;
            output = input * input;
            return output;
        }

        public int MultiplyByTen(int input)
        {
            int output = 10 * input;
            return output;
        }

        public ulong Factorial(int input)
        {
            ulong in_long = (ulong)input;
            ulong output = (ulong)input;
            for(ulong i = in_long; i > 1; i--)
            {
                output = output * (i - 1);
            }
            return output;
        }

        public double HalfIt(int input)
        {
            double output = Convert.ToDouble(input) / 2;
            return output;
        }
    }
}
