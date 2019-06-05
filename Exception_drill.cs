using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exception_drill
{
    static void Main()
    {
        List<int> myInts = new List<int>() { 2365, 34, 0, 1, 99, 14, 53, 8 };
        Console.WriteLine("Pick a number to divide each number by.");

        try
        {
            int numberOne = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myInts.Count; i++)
            {
                int quotient = myInts[i] / numberOne;
                Console.WriteLine(quotient);
            }
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Don't you know you can't divide by zero?");
        }
        catch (FormatException)
        {
            Console.WriteLine("What on earth were you thinking, putting in text like that?");
        }
        finally
        {
            Console.WriteLine("You are no being redirected out of the try/catch block.");
        }
        Console.WriteLine("Have a nice day!");
        Console.Read();
    }
}
