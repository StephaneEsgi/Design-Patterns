using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MyIterableData> datas = new List<MyIterableData>{
                new MyIterableData("id1", "1", "2", "3", "4", "5", "6", "7"),
                new MyIterableData("id2", "2", "4", "6", "8", "10", "12", "14"),
                new MyIterableData("id3", "pif", "paf", "pouf", "plif", "plaf", "plouf"),
                new MyIterableData("id4", "tic", "tac", "tic", "tac", "tic", "tac", "tic", "tac", "tic", "tac"),
            };

            foreach (var items in datas)
            {
                System.Console.WriteLine();
                foreach (var subItem in items)
                {
                    System.Console.Write($"{subItem} ");
                }
            }
            System.Console.WriteLine();
            Console.ReadLine();
        }
    }
}
