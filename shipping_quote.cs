using System;

class Class1
{
    static void Main() {

        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nWhat is your package weight?");
        double weight = Convert.ToDouble(Console.ReadLine());
        
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            Console.Read();
        }
        else
        {
            Console.WriteLine("What is your package width?");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your package height?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your package length?");
            double length = Convert.ToDouble(Console.ReadLine());
            double sum = width + height + length;

            string result = sum > 50 ? "Package is too big to be shipped via Package Express." : "The cost for shipping this package is $" + (sum * weight) / 100 + "\nThank you.";
            Console.Write(result);
            Console.Read();
        }
    }
}