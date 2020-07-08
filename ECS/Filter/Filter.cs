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
        public void AddListener(IFilterListener filterListener)
        {
            Listeners.Add(filterListener);
        }

        /// <summary>
        /// Tar bort en listener från events
        /// </summary>
        public void RemoveListener(IFilterListener filterListener)
        {
            Listeners.Remove(filterListener);
        }

        /// <summary>
        /// Kör listeners
        /// </summary>
        protected void RunListeners(in Entity entity)
        {
            foreach (var listener in Listeners)
            {
                // ToDo: Hitta något bra sätt att filtrera på förutom att skicka med mer skit
                listener.OnEntityAdded(entity);
                listener.OnEntityRemoved(entity);
                
            }
        }

        public abstract void OnAddEntity(in Entity entity);
        public abstract void OnRemoveEntity(in Entity entity);
    }
}