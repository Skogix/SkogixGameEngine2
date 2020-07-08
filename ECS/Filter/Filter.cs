using System;
using System.Collections.Generic;

namespace ECS
{
    /// <summary>
    /// Container för filtrerade entities
    /// </summary>
    public abstract class Filter
    {
        protected List<Entity> Entities;
        protected readonly Dictionary<int, int> Map;
        
        protected List<IFilterListener> Listeners = new List<IFilterListener>();

        public List<Type> IncludedTypes;
        public List<Type> ExcludedTypes;

        public Filter()
        {
            Entities = new List<Entity>();
            Map = new Dictionary<int, int>();
        }

        /// <summary>
        /// Lägger till en listener till events
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(IFilterListener listener){}
        
        /// <summary>
        /// Tar bort en listener från events
        /// </summary>
        /// <param name="listener"></param>
        public void RemoveListener(IFilterListener listener){}
        
        /// <summary>
        /// Kör listeners
        /// </summary>
        /// <param name="entity"></param>
        protected void RunListeners(in Entity entity){}

        public abstract void OnAddEntity(in Entity entity);
        public abstract void OnRemoveEntity(in Entity entity);
    }
}