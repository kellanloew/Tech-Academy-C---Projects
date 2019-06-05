using System;

namespace AbstractClassDrill
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            base.SayName();
        }

        public void Quit()
        {
            Console.WriteLine("Press enter to quit the console.");
        }
        public static bool operator== ()
        {

        }
    }
}
