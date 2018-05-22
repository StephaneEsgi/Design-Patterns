using System;
using System.Collections.Generic;

namespace AbstractFactory 
{
    public abstract class AbstractFactory 
    {
        private static Dictionary<Budget, AbstractFactory> factories = new Dictionary<Budget, AbstractFactory>();

        static AbstractFactory() 
        {
            factories.Add(Budget.LOW, new BottomRangeComputerFactory());
            factories.Add(Budget.MIDDLE, new MiddleRangeComputerFactory());
            factories.Add(Budget.HIGH, new TopRangeComputerFactory());
            factories.Add(Budget.OUT, new OutOfRangeComputerFactory());
        }

        public static AbstractFactory GetFactory(Budget budget)
        {
            return factories[budget];
}


        public abstract Cpu CreateCpu();
        public abstract MotherBoard CreateMotherBoard();
        public abstract Ram CreateRam();
    }
}