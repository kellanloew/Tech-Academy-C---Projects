using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceDrill
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Id = 0;

            employee.SayName();
            Console.Read();
        }
    }
}
