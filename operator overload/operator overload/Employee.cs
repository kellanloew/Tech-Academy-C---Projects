using System;

namespace OperatorOverwrite
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public override void SayName()
        {
            base.SayName();
        }
        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
                return true;
            else
                return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
                return true;
            else
                return false;
        }
    }
}
