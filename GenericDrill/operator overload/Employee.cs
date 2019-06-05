using System;
using System.Collections.Generic;

namespace GenericDrill
{
    public class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> Things { get; set; } //Defines a generic list

        public override void SayName()
        {
            base.SayName();
        }
        
    }
}
