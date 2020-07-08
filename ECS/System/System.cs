
using System.Collections.Generic;
using NotImplementedException = System.NotImplementedException;

namespace ECS
{
    public class System : IInitSystem, IRunSystem, ISystem
    {
        public readonly string Name;
        public readonly World World;
        readonly Dictionary<int, ISystem> _allSystems = new Dictionary<int, ISystem>();
        readonly Dictionary<int, IRunSystem> _runSystems = new Dictionary<int, IRunSystem>();

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
            for (int i = 0; i < _allSystems.Count; i++)
            {
                var system = _allSystems[i];
                if (system is IInitSystem initSystem)
                {
                    initSystem.Init();
                }
            }

            foreach (var pair in _allSystems)
            {
                if(_allSystems[pair.Key] is IInitSystem initSystem)
                    initSystem.Init();
            }
        }

        /// <summary>
        /// Kör alla IRunSystem
        /// </summary>
        public void Run()
        {
            foreach (var pair in _runSystems)
            {
               _runSystems[pair.Key].Run();
            }
        }
    }
}