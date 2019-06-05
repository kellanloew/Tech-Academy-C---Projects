using System;

namespace EnumDrill
{
    class Program
    {
        static void Main()
        {
            int counter = 0;
            while (counter < 1)
            {
                try
                {
                    Console.WriteLine("Please enter a day of the week.");
                    string day = Console.ReadLine();
                    DayOfWeek blob = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);//Parses input string into a DayOfWeek object, then converts it into a specific DayOfWeekValue
                    Console.Write(blob);
                    Console.Read();
                    counter++;
                }
                catch
                {
                    Console.WriteLine("Please enter a valid day, with the first letter uppercase.");
                }
            }
            
        }
    }
}
