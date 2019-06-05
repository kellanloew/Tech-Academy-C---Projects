using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodDrill5
{
    class Program
    {
        static void Main()
        {
            MathOps Math = new MathOps();
            Console.Write("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int result;
            Math.Divide(input: userNum, quotient: out result);
            Console.WriteLine(result);
            double outNum;
            Math.Divide(input: userNum, quotient: out outNum);
            Console.WriteLine(outNum);
            Console.WriteLine(StringMath.LikeMath(result));
            int byTwo;
            int byThree;
            Math.Divide2and3(userNum, out byTwo, out byThree);
            Console.WriteLine(byTwo + ", " + byThree);
            Console.Read();
        }
    }
}
