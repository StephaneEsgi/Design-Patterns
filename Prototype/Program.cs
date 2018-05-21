using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher1 = new Teacher
            {
                FirstName = "Galileo",
                LastName = "Galilei",
                BirthDate = new DateTime(1564, 2, 15)
            };

            var trueMarieCurie = new Student 
            {
                FirstName = "Marie",
                LastName = "Curie",
                BirthDate = new DateTime(1867, 11, 7),
                IsFemale = true,
                Disciplines = new List<Discipline>{
                    new Discipline{ Name = "Physique", Description = "Sciences de la physique", Teacher = teacher1 }
                }
            };

            System.Console.WriteLine(teacher1);
            System.Console.WriteLine(trueMarieCurie);

            var rebornMarieCurie = trueMarieCurie.Clone();
            rebornMarieCurie.BirthDate = new DateTime(1987, 11, 7);
            System.Console.WriteLine(rebornMarieCurie);

        }
    }
}
