using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pour nos tests, on réinitialise le contexte à chaque lancement
            DBManager.Instance.DropTable<Person>();
            DBManager.Instance.CreateTable<Person>();
            DBManager.Instance.DropTable<Score>();
            DBManager.Instance.CreateTable<Score>();

            // on construit l'invoker et on le garnit des commandes à exécuter
            Invoker invoker = new Invoker();
            invoker.AddCommand(new InsertCommand<Person>(Person.Builder().Id(1).LastName("Guardo").FirstName("Stéphane").Age(34).Build()));
            invoker.AddCommand(new UpdateCommand<Person>(Person.Builder().Id(1).LastName("Guardo").FirstName("Steph").Age(32).Build()));
            invoker.AddCommand(new InsertCommand<Person>(Person.Builder().Id(2).LastName("Snow").FirstName("John").Age(28).Build()));
            invoker.AddCommand(new InsertCommand<Score>(Score.Builder().Id(2).Value(18.3f).Date(DateTime.Now).Build()));            
            // on lance l'exécution !
            invoker.ExecuteAll();

            DBManager.Instance.GetAll<Person>().ForEach(item => System.Console.WriteLine(item));
            DBManager.Instance.GetAll<Score>().ForEach(item => System.Console.WriteLine(item));
            
            System.Console.WriteLine("\nSeconde passe - doit produire une erreur\n");

            // on ajoute de nouvelles commandes à exécuter
            invoker.AddCommand(new DeleteCommand<Person>(Person.Builder().Id(1).LastName("Guardo").FirstName("Steph").Age(32).Build()));
            invoker.AddCommand(new InsertCommand<Person>(Person.Builder().Id(3).LastName("Guardo").FirstName("Stéphane").Age(34).Build()));
            invoker.AddCommand(new UpdateCommand<Person>(Person.Builder().Id(3).LastName("Guardo").FirstName("Steph").Age(32).Build()));
            // Cette instruction va produire une erreur de contrainte d'unicité sur la clé primaire précédemment insérée
            invoker.AddCommand(new InsertCommand<Person>(Person.Builder().Id(3).LastName("Snow").FirstName("John").Age(28).Build()));
            // on lance l'exécution, qui va planter dans ce cas à la denrière commande et va donc "rollback" toutes les commandes  de la liste en cours (présente dans l'invoker)
            invoker.ExecuteAll();

            // Ces appels produisent le même affichage que le précédent car toutes les commandes ont été annulées
            DBManager.Instance.GetAll<Person>().ForEach(item => System.Console.WriteLine(item));
            DBManager.Instance.GetAll<Score>().ForEach(item => System.Console.WriteLine(item));
        }
    }
}
