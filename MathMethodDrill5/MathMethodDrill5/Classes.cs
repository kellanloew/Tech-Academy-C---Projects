using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodDrill5
{
    class MathOps
    {
        public void Divide(int input, out int quotient)
        {
            quotient = input / 2;
        }

        public void Divide(int input, out double quotient)
        {
            quotient = (double)input / 2;
        }

        public void Divide2and3(int input, out int byTwo, out int byThree)
        {
            byTwo = input / 2;
            byThree = input / 3;
        }
    }
    static class StringMath
    {
        public static string LikeMath(int inNum)
        {
            string myString = Convert.ToString(inNum);
            return "I like the number " + myString;
        }
    }
}
