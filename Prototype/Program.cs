using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using static System.Console;

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

            WriteLine(teacher1);
            WriteLine(trueMarieCurie);

            var rebornMarieCurie = trueMarieCurie.Clone();
            rebornMarieCurie.BirthDate = new DateTime(1987, 11, 7);
            WriteLine(rebornMarieCurie);


            // au travers du mécanisme de deep-copy
            var deepRebornMarieCurie = JsonConvert.DeserializeObject<Student>(JsonConvert.SerializeObject(trueMarieCurie));
            deepRebornMarieCurie.BirthDate = new DateTime(1987, 11, 7);
            WriteLine(deepRebornMarieCurie);


            // au travers d'une Factory
            var rebornMarieCurieFromPrototypeFactory = PrototypeFactory.GetPrototype<Student>();
            System.Console.WriteLine(rebornMarieCurieFromPrototypeFactory);
        }
    }
}
