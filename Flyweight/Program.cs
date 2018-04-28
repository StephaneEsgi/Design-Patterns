using System;
using System.Linq;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree(new List<Shape>{
                new Shape{ Name = "shape 1"},
                new Shape{ Name = "shape 2"},
                new Shape{ Name = "shape 3"},
                new Shape{ Name = "shape 4"}
            });

            var flyTrees = new List<FlyTree>{
                new FlyTree("Arbre 1", tree, new Vector3(0f,0f,0f), new Vector3(0f,0f,0f), 1f),
                new FlyTree("Arbre 2", tree, new Vector3(1f,1f,1f), new Vector3(180f,0f,0f), 1f),
                new FlyTree("Arbre 3", tree, new Vector3(2f,2f,2f), new Vector3(0f,90f,0f), 12f),
                new FlyTree("Arbre 4", tree, new Vector3(3f,3f,3f), new Vector3(0f,0f,-90f), 0.8f),
                new FlyTree("Arbre 5", tree, new Vector3(4f,4f,4f), new Vector3(180f,270f,90f), 1f),
            };

            flyTrees.ForEach(Console.WriteLine);
            
            Console.WriteLine();
        }
    }
}
