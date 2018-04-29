using System;

namespace Adapter 
{
    public class RgbToRgbaAdapter : IArgbColor
    {
        RgbColor rgbColor;

        public RgbToRgbaAdapter(RgbColor rgbColor)
        {
            this.rgbColor = rgbColor;
        }

        public ArgbColor GetArgbColor()
        {
            return GetArgbColor(255);
        }

        public ArgbColor GetArgbColor(int alpha)
        {
            return new ArgbColor(alpha, rgbColor.R, rgbColor.G, rgbColor.B);
        }
    }
}