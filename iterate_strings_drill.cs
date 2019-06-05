using System;
using System.Collections.Generic;

class iterate_strings
{
    static void Main()
    {
        string[] givenStrings = new string[] { "I like a big ", "Sometimes you meet a person who is ", "Hello, " };

        Console.WriteLine("Enter a word or phrase.");
        string userString = Console.ReadLine();

        for(int i = 0; i < givenStrings.Length; i++)
        {
            givenStrings[i] += userString;
        }
        foreach(string thing in givenStrings)
        {
            Console.WriteLine(thing);
        }

        Console.WriteLine();

        for (int j = 100; j < 125; j++) //Change ++ to -- in order to make it infinite
        {
            Console.WriteLine("Hi.");
        }

        Console.WriteLine();

        for (int k = 0; k <= 15; k++)
        {
            Console.WriteLine(k);
        }

        Console.Write("\n");

        for (int j = 1; j <= 15; j++)
        {
            Console.WriteLine(j);
        }

        Console.Write("\n");

        List<string> searchString = new List<string>() { "hello", "Communism", "Socialism", "Fascism", "people"};
        Console.WriteLine("Enter some text to search for in the list.");
        string userText = Console.ReadLine();

        short counter = 0;
        for (int i = 0; i < searchString.Count && counter == 0; i++)
        {
            if (searchString[i] == userText)
            {
                Console.WriteLine("Index is: " + i);
                counter++;
            }
            if(counter == 0 && i == searchString.Count - 1)
            {
                Console.WriteLine(userText + " is not a match.");
            }
        }

        List<string> identicalStrings = new List<string>() { "narrow", "high", "slippery", "high", "rocky"};
        Console.WriteLine("Enter some text to search for in the list.");
        userText = Console.ReadLine();

        counter = 0;
        for(int j = 0; j < identicalStrings.Count; j++)
        {
            if(identicalStrings[j] == userText)
            {
                Console.WriteLine("Index is: " + j);
                counter++;
            }
            if(counter == 0 && j == identicalStrings.Count - 1)
            {
                Console.WriteLine(userText + " is not a match. ");
            }
        }

        List<string> identicalStrings2 = new List<string>() { "Maine", "Kansas", "Nevada", "Maine", "Kansas", "Colorado", "Maine", "Ohio" };

        for (int j = 0; j < identicalStrings2.Count; j++) //Loop[ through our given list
        {
            string curr = identicalStrings2[j];
            Console.Write("The string is: " + curr + ". "); //Print current string

            counter = 0;
            for (int i = 0; i < j; i++) //Loop through the list up to where we've been 
            {
                if (identicalStrings2[i].Equals(curr) && counter == 0) //See if current string is already there
                {
                    Console.Write(curr + " has already appeared before.");
                    counter++;
                }
            }
            Console.Write("\n");
        }
        Console.Read();
    }
}
