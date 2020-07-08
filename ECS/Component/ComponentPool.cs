using System;
using System.Collections.Generic;
using System.Linq;

namespace ECS
{
    public sealed class ComponentPool
    {
        internal static int ComponentTypesCount;
    }

    public sealed class ComponentPool<T> : IComponentPool where T : struct
    {
        public Type ItemType { get; }
        public object GetItem(int id)
        {
            if (Components.ContainsKey(id)) return Components[id];
            
            return null;
        }


        public Dictionary<int, T> Components = new Dictionary<int, T>();

        public ComponentPool()
        {
            ItemType = typeof(T);
        }
    }
}