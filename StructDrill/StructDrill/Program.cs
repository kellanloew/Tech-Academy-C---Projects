using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDrill
{
    class Program
    {
        static void Main()
        {
            Number myNum = new Number();
            myNum.Amount = 123.456m;
            Console.WriteLine(myNum.Amount);
            Console.Read();
        }
    }
}
