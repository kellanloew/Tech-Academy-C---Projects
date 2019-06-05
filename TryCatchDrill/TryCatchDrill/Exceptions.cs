using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDrill
{
    public class Exceptions : Exception //Exceptions inherits from exception class
    {
        public Exceptions()
            : base() { }
        public Exceptions(string message) //Overloading the Exceptions method to take a custom string
            : base("Hey! " + message) { }
    }
}
