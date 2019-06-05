using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDrill
{
    class Program
    {
        static void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();

            employee.firstName = "Joe";
            employee.lastName = "Biden";
            employee.Id = 0;
            employeeList.Add(employee);
            employee.firstName = "Helen";
            employee.lastName = "McDonough";
            employee.Id = 1;
            employeeList.Add(employee);
            employee.firstName = "Donald";
            employee.lastName = "Trump";
            employee.Id = 2;
            employeeList.Add(employee);
            employee.firstName = "Barack";
            employee.lastName = "Obama";
            employee.Id = 3;
            employeeList.Add(employee);
            employee.firstName = "George";
            employee.lastName = "Bush";
            employee.Id = 4;
            employeeList.Add(employee);
            employee.firstName = "Bill";
            employee.lastName = "Clinton";
            employee.Id = 5;
            employeeList.Add(employee);
            employee.firstName = "Mary";
            employee.lastName = "Smallfoot";
            employee.Id = 6;
            employeeList.Add(employee);
            employee.firstName = "Jimmy";
            employee.lastName = "Carter";
            employee.Id = 7;
            employeeList.Add(employee);
            employee.firstName = "Joe";
            employee.lastName = "Brown";
            employee.Id = 8;
            employeeList.Add(employee);
            employee.firstName = "Joe";
            employee.lastName = "Rodriguez";
            employee.Id = 9;
            employeeList.Add(employee);
            employee.firstName = "Ben";
            employee.lastName = "Shapiro";
            employee.Id = 10;
            employeeList.Add(employee);

            List<Employee> JoeNames1 = new List<Employee>();
            foreach (Employee emp in employeeList)
            {
                if(emp.firstName == "Joe")
                {
                    JoeNames1.Add(emp);
                    Console.WriteLine(emp.lastName);
                }
            }
            Console.WriteLine();

            List<Employee> JoeNames2 = new List<Employee>();
            JoeNames2 = employeeList.Where(x => x.firstName == "Joe").ToList();

            foreach (Employee emp in JoeNames2)
            {
                Console.WriteLine(emp.lastName);
            }
            Console.WriteLine();

            List<Employee> GreaterThan5 = new List<Employee>();
            GreaterThan5 = employeeList.Where(y => y.Id > 5).ToList();

            foreach (Employee emp in GreaterThan5)
            {
                Console.WriteLine(emp.firstName + " " + emp.Id);
            }

            int hello = 45;

            for(; ; )
            {
                if (hello < 100)
                {
                    Console.WriteLine(hello);
                    hello++;
                }
                else break;
            }
            Console.Read();

        }
    }
}
