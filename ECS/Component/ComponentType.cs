using System;
using System.Threading;

namespace ECS
{
    public static class ComponentType<T> where T : struct
    {
        public static readonly int TypeIndex;
        public static readonly Type Type;

        static ComponentType()
        {
            // gimme all teh threads!
            TypeIndex = Interlocked.Increment(ref ComponentPool.ComponentTypesCount);
            Type = typeof(T);
        }
        
    }
}