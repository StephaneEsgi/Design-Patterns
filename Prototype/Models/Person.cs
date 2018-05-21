using System;
using System.Collections.Generic;

namespace Prototype 
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsFemale { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, né{(IsFemale?"e":"")} le {BirthDate.ToString("dd/MM/yyyy")}";
        }
    }
}