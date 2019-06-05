using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            ushort age = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            ushort tickets = Convert.ToUInt16(Console.ReadLine());
            bool qualified = age > 15 && DUI == false && tickets <= 3;
            Console.WriteLine("Qualified?\n" + qualified);
            Console.ReadLine();
        }
    }
}
