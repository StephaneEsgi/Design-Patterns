using System;
using System.Collections.Generic;

namespace Command {
    public class Invoker 
    {
        List<Command> commands = new List<Command>();

        public void AddCommand(Command command) {
            commands.Add(command);
        }

        public void ExecuteAll() {
            int index = 0; // l'initialisation de cette variable est faite en dehors de la boucle for afin d'étendre sa portée à toute la méthode
            try {
                for (; index < commands.Count; index++) // l'initialisation de la variable de la boucle est faite plus haut
                    commands[index].Execute();
                commands.Clear(); // on nettoie les commandes à la fin du processus pour se resservir de cet invoker
            } catch (Exception exception) {
                System.Console.WriteLine($"Erreur : [{exception.Message}]");
                // on décrémente car on ne veut pas annuler la dernière commande tentée, puisque celle-ci a échoué !
                for (index--; index >= 0; index--)
                    commands[index].Cancel();
                commands.Clear(); // on nettoie les commandes à la fin du processus pour se resservir de cet invoker
            }
        }
    }
}