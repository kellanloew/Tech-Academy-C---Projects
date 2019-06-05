using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritanceDrill
{
    public class Person
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
