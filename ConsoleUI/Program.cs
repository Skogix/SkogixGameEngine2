using System;
using ECS;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();
            Entity entity = world.NewEntity();
        }
    }
}