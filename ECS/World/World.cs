using System.Collections.Generic;
using System.Threading;

namespace ECS
{
    public class World
    {
        protected List<EntityData> Entities;
        protected int EntitiesCount;

        private protected readonly Dictionary<int, List<Filter>> FilterByIncludedComponents;
        private protected readonly Dictionary<int, List<Filter>> FilterByExcludedComponents;

        public List<IComponentPool> ComponentPools;

        public World()
        {
            Entities = new List<EntityData>();
            ComponentPools = new List<IComponentPool>();
            FilterByIncludedComponents = new Dictionary<int, List<Filter>>();
            FilterByExcludedComponents = new Dictionary<int, List<Filter>>();
        }

        /// <summary>
        /// Uppdaterar filters
        /// Minus för remove, plus för add
        /// Skicka in target
        /// </summary>
        protected internal void UpdateFilters(int typeId, in Entity entity)
        {
            List<Filter> filters;
            
            if (typeId < 0)
            {
                // ta bort component component
                if (FilterByIncludedComponents.TryGetValue(-typeId, out filters))
                    foreach (var filter in filters)
                        filter.OnAddEntity(entity);
                if (FilterByExcludedComponents.TryGetValue(-typeId, out filters))
                    foreach (var filter in filters)
                        filter.OnRemoveEntity(entity);
            } else {
                // lägg till component
                if (FilterByIncludedComponents.TryGetValue(typeId, out filters))
                    foreach (var filter in filters)
                        filter.OnAddEntity(entity);
                if (FilterByExcludedComponents.TryGetValue(typeId, out filters))
                    foreach (var filter in filters)
                        filter.OnRemoveEntity(entity);
            }
        }
        
        
    }
}