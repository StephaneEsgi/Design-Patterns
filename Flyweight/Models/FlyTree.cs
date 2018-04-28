using System;

namespace Flyweight
{
    public class FlyTree
    {
        Tree tree;
        public string Name { get; set; }
        Vector3 Position {get; set; }
        Vector3 Rotation {get; set; }
        float Scale {get; set; }
        public bool Destroyed { get; set; }

        public FlyTree(string name, Tree tree, Vector3 position, Vector3 rotation, float scale)
        {
            Name = name;
            this.tree = tree;
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public override string ToString(){
            return $"[{Name}] Position[{Position}] Rotation[{Rotation}] Scale[{Scale}] Shapes[{tree.Render()}] Destroyed[{Destroyed}]";
        }
    }
}