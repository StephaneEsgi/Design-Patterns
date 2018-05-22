using System;

namespace AbstractFactory
{
    public class TopRangeComputerFactory : AbstractFactory
    {
        public override Cpu CreateCpu()
        {
            return new Cpu {
                Brand = "Intel",
                ModelName = "i7",
                Price = 659f
            };
        }

        public override MotherBoard CreateMotherBoard()
        {
            return new MotherBoard {
                Brand = "Asus",
                ModelName = "Top range",
                Price = 159f
            };
        }

        public override Ram CreateRam()
        {
            return new Ram {
                RamType = "DDR4",
                GbSize = 16,
                Price = 320f
            };
        }
    }
}