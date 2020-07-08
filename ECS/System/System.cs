
using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace ECS
{
    public class System : IInitSystem, IRunSystem, ISystem
    {
        public readonly string Name;
        public readonly World World;
        readonly List<ISystem> _allSystems = new List<ISystem>();

        public System(World world, string name)
        {
            World = world;
            Name = name;
        }
       
        /// <summary>
        /// Stänger chansen att regga nya system.
        /// Inita _allSystems
        /// </summary>
        public void Init()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Kör alla IRunSystem
        /// </summary>
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}