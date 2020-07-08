using System.Collections.Generic;

namespace ECS
{
    public struct EntityData
    {
        public ushort Gen;
        public List<int> Components;
    }
}