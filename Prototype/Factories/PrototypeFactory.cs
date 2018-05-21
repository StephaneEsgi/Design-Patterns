using System;
using System.Collections.Generic;

namespace Prototype {
    public static class PrototypeFactory {

        private static Dictionary<Type,object> prototypes = new Dictionary<Type, object>();

        static PrototypeFactory() {
            // initialisation des prototypes
            
            prototypes.Add(typeof(Teacher), new Teacher
            {
                FirstName = "Galileo",
                LastName = "Galilei",
                BirthDate = new DateTime(1564, 2, 15)
            });

            prototypes.Add(typeof(Student), new Student 
            {
                FirstName = "Marie",
                LastName = "Curie",
                BirthDate = new DateTime(1867, 11, 7),
                IsFemale = true,
                Disciplines = new List<Discipline>{
                    new Discipline{ Name = "Physique", Description = "Sciences de la physique", Teacher = (Teacher) prototypes[typeof(Teacher)] }
                }
            });
        }

        public static T GetPrototype<T>() where T : new()
        {
            // cette méthode retourne soit le prototype s'il a été renseigné, soit une nouvelle instance de la classe demandée
            return prototypes.ContainsKey(typeof(T)) ? (T) prototypes[typeof(T)] : new T();
        }
    }
}