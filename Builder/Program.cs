using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = Student.Builder()         // initialisation du builder
                                 .Name("Guardo")    //ajout des différents attributs
                                 .FirstName("Stéphane")
                                 .Role("Professeur")
                                 .Id(3)
                                 .Build();          // récupération de l'instance garnie de tous les attributs

            System.Console.WriteLine(student);

            // ici on fait une instantiation au travers du contructeur vide, 
            // puis on ajoute les propriétés une à une à l'instance (méthode "classique")
            var student2 = new Student();
            student2.Name = "Guardo";
            student2.FirstName = "Stéphane";
            student2.Role = "Professeur";
            student2.Id = 3;

            System.Console.WriteLine(student2);
        }
    }
}
