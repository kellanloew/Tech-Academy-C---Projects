using System;

class math_operators
{
    static void Main()
    {

        Console.WriteLine("Enter a number: ");
        int userNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(userNum * 50);
        Console.WriteLine("Enter another number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(userNum + 25);
        Console.WriteLine("Enter another number: ");
        double decNum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(decNum / 12.5);
        Console.WriteLine("Enter another number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        bool greaterThan50 = userNum > 50;
        Console.WriteLine(greaterThan50);
        Console.WriteLine("Enter another number: ");
        userNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(userNum % 7);
        Console.ReadLine();
    }
}