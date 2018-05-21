using System;
using System.Text;
using System.Collections.Generic;

namespace Prototype 
{
    public class Student : Person, IClonable<Student>
    {
        public List<Discipline> Disciplines { get; set; }

        #region Constructors
        public Student(){}

        //Une façon de faire
        public Student(Student source)
        {
            this.LastName = source.LastName;
            this.FirstName = source.FirstName;
            this.IsFemale = source.IsFemale;
            this.BirthDate = new DateTime(source.BirthDate.Ticks);
            this.Disciplines = new List<Discipline>();
            foreach (var discipline in source.Disciplines)
                this.Disciplines.Add(new Discipline(discipline));
        }
        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();
            if(Disciplines != null && Disciplines.Count > 0)
                Disciplines.ForEach(m => sb.Append(m).Append(" "));

            return $"{base.ToString()}\n\t{sb.ToString()}";
        }

        //Une autre façon de faire
        public Student Clone()
        {
            var newStudent = new Student{
                LastName = this.LastName,
                FirstName = this.FirstName,
                IsFemale = this.IsFemale,
                BirthDate = new DateTime(this.BirthDate.Ticks),
                Disciplines = new List<Discipline>()
            };
            
            foreach (var discipline in this.Disciplines)
                newStudent.Disciplines.Add(new Discipline(discipline));

            return newStudent;
        }
    }
}