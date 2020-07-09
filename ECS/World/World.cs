using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ECS
{
    public class World
    {
        protected EntityData[] Entities;
        protected int EntitiesCount;

        private protected readonly Dictionary<string, List<Filter>> FilterByIncludedComponents;
        private protected readonly Dictionary<string, List<Filter>> FilterByExcludedComponents;

        public Dictionary<string, IComponent> ComponentPools;

        public World()
        {
            Entities = new EntityData[128];
            EntitiesCount = 0;
            ComponentPools = new Dictionary<string, IComponent>();
            FilterByIncludedComponents = new Dictionary<string, List<Filter>>();
            FilterByExcludedComponents = new Dictionary<string, List<Filter>>();
        }

        public Entity NewEntity()
        {
            // lär kolla upp mer lösningar att newa structs, kommer bli ett helvete senare
            Entity entity = new Entity();
            entity.Owner = this;
            entity.Id = EntitiesCount++;
            ref var entityData = ref Entities[entity.Id];
            entityData.Components = new List<IComponent>();
            return entity;
        }
        
        protected internal void UpdateFilters(string componentId, in Entity entity)
        {
            List<Filter> filters;
            
            /*
            // ta bort component component
            if (FilterByIncludedComponents.TryGetValue(-typeId, out filters))
                foreach (var filter in filters)
                    filter.OnAddEntity(entity);
            if (FilterByExcludedComponents.TryGetValue(-typeId, out filters))
                foreach (var filter in filters)
                    filter.OnRemoveEntity(entity);
            
            // lägg till component
            if (FilterByIncludedComponents.TryGetValue(typeId, out filters))
                foreach (var filter in filters)
                    filter.OnAddEntity(entity);
            if (FilterByExcludedComponents.TryGetValue(typeId, out filters))
                foreach (var filter in filters)
                    filter.OnRemoveEntity(entity);
        */
        }
        
        
    }
}