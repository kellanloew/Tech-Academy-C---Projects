using System;
using System.Text;

class string_drill
{
    static void Main()
    {
        Console.WriteLine("Enter your name.");
        string name = Console.ReadLine();
        string poemName = "The wasteland";
        Console.WriteLine("Hi " + name + ", here is an excerpt from the "+ poemName.ToUpper() + ":\n");

        StringBuilder my_string = new StringBuilder();
        my_string.Append("What are the roots that clutch, what branches grow");
        my_string.Append(" Out of this stony rubbish? Son of man,");
        my_string.Append(" You cannot say, or guess, for you know only");
        my_string.Append(" A heap of broken images, where the sun beats,");
        my_string.Append(" And the dead tree gives no shelter, the cricket no relief,");
        my_string.Append(" And the dry stone no sound of water.");
        Console.WriteLine(my_string);
        Console.Read();
    }
}
