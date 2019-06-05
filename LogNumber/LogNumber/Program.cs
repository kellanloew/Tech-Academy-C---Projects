using System;
using System.IO;

namespace LogNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number.");
            string userNum = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\TTA_DEN_STUDENT\test.txt", false))
            {
                file.WriteLine(userNum);
            }
            Console.WriteLine(File.ReadAllText("C:\\Users\\TTA_DEN_STUDENT\\test.txt"));
            Console.Read();
        }
    }
}
