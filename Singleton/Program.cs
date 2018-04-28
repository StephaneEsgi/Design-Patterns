using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // On appelle l'instance unique de DBConnection, 
            // et on conserve un pointeur vers cette instance pour des raisons de performance 
            // (chaque appel à GetInstance() a un coût, si "infime" soit-il)
            var dbConnection = DBConnection.GetInstance();

            // On ajoute un élément à nos FakeData
            dbConnection.Add("MOC");

            // On récupère toutes les entrées de nos FakeData
            var data = dbConnection.GetAll();

            // On affiche toutes les entrées, pour vérifier que notre programme a le fonctionnement attendu
            foreach(var s in data)
                System.Console.WriteLine(s);
        }
    }
}
