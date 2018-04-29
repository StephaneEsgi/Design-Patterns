using System;
using static System.Console;

namespace Adapter 
{
    public class WhatEver 
    {
        // on fait un traitement qui ne peut pas s'effectuer avec une couleur RGB
        public void DoSomethingWithArgbColor(ArgbColor color)
        {
            WriteLine($"Je fais quelque chose avec la couleur {color}");
        }
    }
}