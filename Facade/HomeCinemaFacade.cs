using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace Facade
{
    public class HomeCinemaFacade 
    {
        Amplificateur ampli;
        Tuner tuner;
        LecteurDvd dvd; 
        LecteurCd cd;
        Projecteur projecteur;
        List<Lumiere> lumieres;
        Ecran ecran;
        MachineAPopcorn machineAPopCorn; 

        public HomeCinemaFacade (Amplificateur ampli, Tuner tuner, LecteurDvd dvd, LecteurCd cd, Projecteur projecteur, Ecran ecran, List<Lumiere> lumieres, MachineAPopcorn machineAPopCorn) 
        {
            this.ampli = ampli;
            this.tuner = tuner;
            this.dvd = dvd;
            this.cd = cd;
            this.projecteur = projecteur;
            this.ecran = ecran;
            this.lumieres = lumieres;
            this.machineAPopCorn = machineAPopCorn;
        }

        public void RegarderUnFilm(string film){
            WriteLine("Vous allez voir un bon film..."); 
            machineAPopCorn.Marche(); 
            machineAPopCorn.Eclater();
            lumieres.ForEach(l => l.Attenuer(10));
            ecran.Baisser();
            projecteur.Marche();
            projecteur.ModeGrandEcran();
            ampli.Marche();
            ampli.SetSonSurround();
            ampli.SetVolume(5);
            dvd.Marche() ;
            dvd.Jouer(film);
        }

        public void EcouterMusique(string musique){
            // ...
        }

        public void ArreterLeFilm(){
            WriteLine("C’est la fin du film...");
            machineAPopCorn.Arret();
            lumieres.ForEach(l => l.Marche());
            ecran.Monter();
            projecteur.Arret();
            ampli.Arret();
            dvd.Stop();
            dvd.Ejecter();
            dvd.Arret();
        }

    }
}