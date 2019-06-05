using System;

namespace Consoler
{

    class myProgram
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Report\nWhat course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            int pageNum = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            int hours = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
