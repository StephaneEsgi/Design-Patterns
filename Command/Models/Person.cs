using System;
using SQLite;

namespace Command {
    public class Person
    {
        
        public static PersonBuilder Builder(){
            return new PersonBuilder();
        }

        [PrimaryKey]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }

        public Person() {}

        public override String ToString() => $"Person[{Id}, {FirstName}, {LastName}, {Age}]";

        #region Builder
        public class PersonBuilder{
            Person person;

            public PersonBuilder()
            {
                person = new Person();
            }

            public PersonBuilder Id (int id){
                person.Id = id;
                return this;
            }
            public PersonBuilder FirstName (string firstname){
                person.FirstName = firstname;
                return this;
            }
            public PersonBuilder LastName (string lastName){
                person.LastName = lastName;
                return this;
            }
            public PersonBuilder Age (int age){
                person.Age = age;
                return this;
            }

            public Person Build(){
                return person;
            }

        }
        #endregion

    }
}