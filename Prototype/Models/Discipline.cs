using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Prototype 
{
    public class Discipline 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; }
        public List<Mark> Marks { get; set; }

        #region Constructors
        public Discipline(){}

        //Une façon de faire
        public Discipline(Discipline source)
        {
            this.Name = source.Name;
            this.Description = source.Description;
            this.Teacher = new Teacher(source.Teacher);
            this.Marks = new List<Mark>();
            if(source.Marks != null)
                foreach (var mark in source.Marks)
                    this.Marks.Add(new Mark(mark));
        }
        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder();
            if(Marks != null && Marks.Count > 0)
                Marks.ForEach(m => sb.Append(m).Append(" "));

            return $"{Name} ({Description}), Professeur : {Teacher} {(sb.Length > 0? sb.ToString():"")}";
        }

        //Une autre façon de faire
        public Discipline Clone()
        {
            var newDiscipline = new Discipline{
                Name = this.Name,
                Description = this.Description,
                Teacher = new Teacher(this.Teacher),
                Marks = new List<Mark>()
            };

            foreach (var mark in this.Marks)
                this.Marks.Add(new Mark(mark));
            
            return newDiscipline;
        }
    }
}