using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethod2
{
    public class MathOperation
    {
        public void Exponent(int input, int power)
        {
            int output = input;
            if (power > 0)
            {
                if (power == 1)
                {
                    output = 1;
                }
                for (int i = 0; i < power; ++i)
                {
                    output = input * output;
                }
            }
            else
            {
                output = 1;
            }

            Console.WriteLine(power);
        }
    }
}
