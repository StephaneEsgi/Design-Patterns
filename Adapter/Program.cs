using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var whatEver = new WhatEver();
            var rgbColor = new RgbColor(255, 128, 0);

            // ici je décompose l'appel à l'adapter, mais on aurait pu tout mettre dans l'appel de DoSomethingWithArgbColor
            var rgbToRgbaAdapter = new RgbToRgbaAdapter(rgbColor);

            // ici on aura adapté la couleur RGB en ARGB pour que le traitement puisse s'effectuer
            whatEver.DoSomethingWithArgbColor(rgbToRgbaAdapter.GetArgbColor());
        }
    }
}
