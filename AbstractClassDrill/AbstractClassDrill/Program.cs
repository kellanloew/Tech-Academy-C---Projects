using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            IQuittable exit = new Employee();
            exit.Quit();
            Console.Read();
        }
    }
}
