using System;
using System.Collections.Generic;
using System.Linq;

namespace ECS
{
    public sealed class Component<T> : IComponent where T : struct
    {
        public Type ItemType { get; }
        public object GetItem(int id)
        {
            if (Components.ContainsKey(id)) return Components[id];
            
            return null;
        }


        public Dictionary<int, T> Components = new Dictionary<int, T>();

        public Component()
        {
            ItemType = typeof(T);
        }
    }
}