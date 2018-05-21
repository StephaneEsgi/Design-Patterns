using System;

namespace AbstractFactory 
{
    public class OutOfRangeComputerFactory : AbstractFactory
    {
        public override Cpu createCpu()
        {
            return new Cpu();
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