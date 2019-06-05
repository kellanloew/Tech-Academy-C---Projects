using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethodDrill3
{
    class Program
    {
        static void Main()
        {
            MathOperations MathOpers = new MathOperations();
            Console.WriteLine(MathOpers.MethodOf10(12));
            Console.WriteLine(MathOpers.MethodOf10(38.234M));
            Console.WriteLine(MathOpers.MethodOf10("asdf"));
            Console.Read();
        }
    }
}
