using System;
using System.Collections.Generic;

namespace Prototype 
{
    public class Teacher : Person, IClonable<Teacher>
    {
        #region Constructors
        public Teacher(){}

        //Une façon de faire
        public Teacher(Teacher source){
            this.LastName = source.LastName;
            this.FirstName = source.FirstName;
            this.BirthDate = new DateTime(source.BirthDate.Ticks);
            this.IsFemale = IsFemale;
        }
        #endregion

        //Une autre façon de faire
        public Teacher Clone()
        {
            var newTeacher = new Teacher{
                LastName = this.LastName,
                FirstName = this.FirstName,
                BirthDate = new DateTime(this.BirthDate.Ticks),
                IsFemale = this.IsFemale
            };
            
            return newTeacher;
        }
    }
}