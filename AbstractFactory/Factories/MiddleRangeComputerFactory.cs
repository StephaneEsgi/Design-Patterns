using System;

namespace AbstractFactory 
{
    public class MiddleRangeComputerFactory : AbstractFactory
    {
        public override Cpu CreateCpu()
        {
            return new Cpu {
                Brand = "Intel",
                ModelName = "i3",
                Price = 179f
            };
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new MotherBoard {
                Brand = "Msi",
                ModelName = "Middle range",
                Price = 109f
            };
        }

        public override Ram CreateRam()
        {
            return new Ram {
                RamType = "DDR3",
                GbSize = 8,
                Price = 160f
            };
        }
    }
}