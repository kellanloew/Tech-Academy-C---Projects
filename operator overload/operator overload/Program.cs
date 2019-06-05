using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverwrite
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Joe";
            employee1.lastName = "Bigfoot";
            employee1.Id = 2;
            Employee employee2 = new Employee();
            employee2.firstName = "Harry";
            employee2.lastName = "Smith";
            employee2.Id = 2;
            Employee employee3 = new Employee();
            employee3.firstName = "Mary";
            employee3.Id = 1;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee2 == employee3);

            Console.Read();
        }
    }
}
