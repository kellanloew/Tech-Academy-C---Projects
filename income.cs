using System;

class income_comparison
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate?");
        ushort rate1 = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        ushort hourly1 = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Person 2\nHourly Rate?");
        ushort rate2 = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("Hours worked per week?");
        ushort hourly2 = Convert.ToUInt16(Console.ReadLine());
        int salary1 = rate1 * hourly1;
        int salary2 = rate2 * hourly2;
        Console.WriteLine("Weekly salary of Person 1: " + salary1);
        Console.WriteLine("Weekly salary of Person 2: " + salary2);
        bool moreMoney = salary1 > salary2;
        Console.WriteLine("Does Person 1 make more money than Person 2?\n" + moreMoney);
        Console.ReadLine();
    }
}