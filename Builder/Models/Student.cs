using System;

namespace Builder {

    public class Student{
        #region Builder
        public class StudentBuilder{

        Student student;

        public StudentBuilder()
        {
            student = new Student();
        }

        public StudentBuilder Name (string name){
            student.Name = name;
            return this;
        }

        public StudentBuilder Role (string role){
            student.Role = role;
            return this;
        }

        public StudentBuilder FirstName (string firstname){
            student.FirstName = firstname;
            return this;
        }

        public StudentBuilder Id (int id){
            student.Id = id;
            return this;
        }

        public Student Build(){
            return student;
        }

    }
    #endregion
        
        public static StudentBuilder Builder(){
            return new StudentBuilder();
        }

        public Student()
        {
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Role { get; set; }

        public override string ToString(){
            return $"[Student] {{ Id : {Id}, FirstName : {FirstName}, Name : {Name}}}";
        }
    }
}