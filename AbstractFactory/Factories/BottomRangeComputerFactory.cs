using System;

namespace AbstractFactory 
{
    public class BottomRangeComputerFactory : AbstractFactory
    {
        public override Cpu CreateCpu()
        {
            return new Cpu {
                Brand = "AMD",
                ModelName = "E2",
                Price = 59f
            };
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new MotherBoard {
                Brand = "Acer",
                ModelName = "Bottom range",
                Price = 49f
            };
        }

        public override Ram CreateRam()
        {
            return new Ram {
                RamType = "DDR2",
                GbSize = 4,
                Price = 70f
            };
        }
    }
}