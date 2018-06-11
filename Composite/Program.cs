using System;
using static System.Console;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory root = new Directory("root");
            root.Add(new File("Fichier A"));
            root.Add(new File("Fichier B"));
        
            Directory dir = new Directory("Répertoire X");
            dir.Add(new File("Fichier XA"));
            dir.Add(new File("Fichier XB"));
        
            root.Add(dir);
            root.Add(new File("Fichier C"));
        
            File file = new File("Fichier D");
            root.Add(file);
            root.Remove(file);
        
            // Affichage récursif de l'arbre
            root.Display(1);
        
            ReadKey();
        }
    }
}
