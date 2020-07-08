using System;

namespace ECS
{
    public interface IComponentPool
    {
       Type ItemType { get; }
       object GetItem(int id);
    }
}