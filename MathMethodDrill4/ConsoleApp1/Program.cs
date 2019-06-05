using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            MathOperation Math = new MathOperation();
            Console.WriteLine("Enter a number.");
            int first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another number if you wish. If now, just press enter.");
            string input = Console.ReadLine();
            int outNum;

            try
            {
                int second = Convert.ToInt16(input);
                outNum = Math.Multiply(first, second);
            }
            catch
            {
                outNum = Math.Multiply(first);
            }
            Console.WriteLine(outNum);
            Console.Read();
        }
    }
}
