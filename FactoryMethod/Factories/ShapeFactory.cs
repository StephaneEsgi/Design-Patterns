using System;

namespace FactoryMethod 
{
    public static class ShapeFactory 
    {
        public static Shape CreateShape(string type) 
        {
            switch (type)
            {
                case "Square":
                    return new Square { SideSize = 2f};
                case "Circle":
                    return new Circle { Radius = 3.1f};
                case "Rectangle":
                    return new Rectangle { LongSideSize = 4f, ShortSideSize = 3f };
                default:
                    return new NullShape();
            }
        }

        public static Shape CreateShape<T>() 
        {
            return CreateShape(typeof(T).Name);
        }
    }
}