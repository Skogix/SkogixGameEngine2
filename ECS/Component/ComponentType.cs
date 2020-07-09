using System;
using System.Threading;

namespace ECS
{
    public static class ComponentType<T> where T : struct
    {
        public static readonly Type Type;

        static ComponentType()
        {
            Type = typeof(T);
        }
        
    }
}