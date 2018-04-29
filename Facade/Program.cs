using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeCinema = new HomeCinemaFacade(
                new Amplificateur (), 
                new Tuner(), 
                new LecteurDvd(),
                new LecteurCd(),
                new Projecteur(),
                new Ecran(),
                new List<Lumiere>{
                    new Lumiere(),
                    new Lumiere()
                },
                new MachineAPopcorn()
            );

            homeCinema.RegarderUnFilm("Pirates des Caraïbes");

            System.Console.WriteLine();

            homeCinema.ArreterLeFilm();

        }
    }
}
