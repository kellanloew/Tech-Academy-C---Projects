using System;

namespace AdditionalFeaturesDrill
{
    class Program
    {
        static void Main()
        {
            const int myConstant = 100;
            Console.WriteLine("Enter some text or number.");
            string userIn = Console.ReadLine();
            try
            {
                var output = Convert.ToInt32(userIn);
                output += myConstant;
                Console.WriteLine(output);

            }
            catch
            {
                var output = userIn + " - I'm a string!";
                Console.WriteLine(output);
            }

            Phone myPhone = new Phone("IOS", "CDMA");
            Console.Write("{0}, {1}, {2}", myPhone.OS, myPhone.network, myPhone.color);
            Console.Read();
        }
    }
}
