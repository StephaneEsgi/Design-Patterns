using System;
using System.Collections.Generic;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var superman = new SuperHero
            {
                Name = "Superman",
                RealName = "Clark Kent",
                Charisma = 200,
                Strength = 10000,
                KmRange = 137f,
                BirthPowers = new List<Power>{
                    new LaserEyes(),
                    new DeathPunch()
                }
            };

            var batman = new Hero
            {
                Name = "Batman",
                RealName = "Bruce Wayne",
                Charisma = 180,
                Strength = 100,
                KmRange = 0.7f
            };

            var batGrapple = new BatGrapple();

            batman.SetHeadGadget(new BatEars());
            batman.SetWristGadget(0, batGrapple);
            batman.SetWristGadget(1, batGrapple);
            batman.SetBeltGadget(0, new BatBomb());

            // on utilise ici le pattern Null Object pour éviter les références nulles, en plaçant un objet qui... ne fait rien !
            batman.SetBeltGadget(1, new NoBeltGadget());
            batman.SetBeltGadget(2, new NoBeltGadget());
            batman.SetBeltGadget(3, new NoBeltGadget());
            batman.SetBeltGadget(4, new NoBeltGadget());

            // Console.WriteLine(superman);
            // Console.WriteLine(batman);

            Console.Write("Batman ");
            batman.UseHeadGadget();

            Console.Write("Batman ");
            batman.UseWristGadget(0);

            // On change à la volée un équipement de Batman
            batman.SetWristGadget(0, new BatRocketLauncher());

            Console.Write("Batman ");
            batman.UseWristGadget(0);
            
        }
    }
}
