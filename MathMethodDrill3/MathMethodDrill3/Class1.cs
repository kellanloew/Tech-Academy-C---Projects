using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodDrill3
{
    public class MathOperations
    {
        public int MethodOf10(int input)
        {
            return input + 10;
        }

        public int MethodOf10(decimal number)
        {
            number = number * 10;
            int newNum = (int)number % 5;
            return newNum;
        }

        public int MethodOf10(string inString)
        {
            int number = 0;
            try
            {
                number = Convert.ToInt32(inString);
                number = number + (number * 10);
            }
            catch
            {
                Console.WriteLine("Don't give me that kind of crap!");
            }
            return number;
        }
    }
}
