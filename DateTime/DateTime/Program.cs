using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    class Program
    {
        static void Main()
        {
            DateTime curTime = DateTime.Now;
            Console.WriteLine(curTime);
            Console.WriteLine("Go ahead and enter a number of hours.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(curTime.AddHours(userNum));
            Console.Read();
        }
    }
}
