using System;

namespace AbstractFactory 
{
    public class BottomRangeComputerFactory : AbstractFactory
    {
        public override Cpu createCpu()
        {
            return new Cpu {
                Brand = "AMD",
                ModelName = "E2",
                Price = 59f
            };
        }

        public override MotherBoard createMotherBoard()
        {
            return new MotherBoard();
        }

        public override Ram createRam()
        {
            return new Ram();
        }
    }
}