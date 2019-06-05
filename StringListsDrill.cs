using System;
using System.Collections.Generic;


class stringStuff
{
    static void Main()
    {
        string[] myStrings = new string[] {"Here is no water but only rock", "Rock and no water and the sandy road", "The road winding above among the mountains", "Which are mountains of rock without water" };
        Console.WriteLine("Select an index to see a line of text!");
        int index = Convert.ToInt16(Console.ReadLine());

        if (index > myStrings.Length - 1)
        {
            Console.WriteLine("Sorry, " + index + " is not a valid index.");
        }
        else
        {
            Console.WriteLine(myStrings[index]);
        }

        int[] myNumbers = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
        Console.WriteLine("Select an index to see a fibonnaci number!");
        index = Convert.ToInt16(Console.ReadLine());

        if (index > myNumbers.Length - 1)
        {
            Console.WriteLine("Sorry, " + index + " is not a valid index.");
        }
        else
        {
            Console.WriteLine(myNumbers[index]);
        }

        List<string> stringList = new List<string>();
        stringList.Add("Tech Academy Denver");
        stringList.Add("8850 W 38th Ave");
        stringList.Add("Wheat Ridge, CO");
        stringList.Add("80033");

        Console.WriteLine("Select an index to see a part of the address.");
        index = Convert.ToInt16(Console.ReadLine());
        if (index > stringList.Count - 1)
        {
            Console.WriteLine("Sorry, " + index + " is not a valid index.");
        }
        else
        {
            Console.WriteLine(stringList[index]);
        }
        Console.Read();
    }
}
