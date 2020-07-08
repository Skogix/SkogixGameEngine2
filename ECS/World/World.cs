using System.Collections.Generic;

namespace ECS
{
    public class World
    {
        protected List<EntityData> Entities;
        protected int EntitiesCount;

        public List<IComponentPool> ComponentPools;

        public World()
        {
            Entities = new List<EntityData>();
            ComponentPools = new List<IComponentPool>();
        }
    }
}