using System;

class booleanstuff
{
    static void Main()
    {
        double number = 0;
        bool lessThan100 = number < 100;

        Console.WriteLine("Enter a number.");
        number = Convert.ToDouble(Console.ReadLine());

        while (lessThan100)
        {

            double factor = number;
            bool greaterThan1 = factor > 1;

            Console.WriteLine("Here are the successive halves of " + number + " greater than 2:");
            do
            {
                Console.WriteLine(factor);
                factor = factor / 2;
                greaterThan1 = factor > 1;
            }
            while (greaterThan1);

            Console.WriteLine("Enter a number/decimal to multiply the last number by, so that the product is less than 100.");
            double multiplicand = Convert.ToDouble(Console.ReadLine());
            number = multiplicand * number;
            Console.WriteLine("Now the number is " + number +".");
            lessThan100 = number < 100;
            if (!lessThan100)
            {
                Console.WriteLine("You've gone past 100! All done.");
                Console.Read();
            }
        }
        
    }
}

