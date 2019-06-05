using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main()
        {
            Employee<string> employee1 = new Employee<string>(); //Creates new employee object, defining its list type as string
            Employee<int> employee2 = new Employee<int>(); //Creates new employee object
            employee1.Things = new List<string>() { "pencils", "pens", "paper", "knife"}; //Assigns new list to employee object, defining its list type as int
            employee2.Things = new List<int>() { 2, 4, 6, 8, 10, 12, 14 }; //Assigns new list to employee object

            foreach (string item in employee1.Things)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach(int number in employee2.Things)
            {
                Console.Write(number + " ");
            }
            Console.Read();
        }
    }
}
