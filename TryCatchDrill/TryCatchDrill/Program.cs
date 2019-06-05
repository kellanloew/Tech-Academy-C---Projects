using System;

namespace TryCatchDrill
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, if you don't mind me being rude, what is your age?");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if(age == 0)
                {
                    throw new Exceptions("You're more than 0 years old..."); //Pass in message to be displayed
                }
                else if (age < 0)
                {
                    throw new Exceptions("Don't be silly, enter a positive number.");
                }
                else
                {
                    int curYear = DateTime.Now.Year;
                    Console.WriteLine("You were born in {0}.", curYear - age - 1);
                    Console.Read();
                }
            }
            catch (Exceptions err)
            {
                Console.WriteLine(err.Message);
                Console.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter whole numbers.");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.Read();
            }
        }
    }
}
