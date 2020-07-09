using System;

namespace ECS
{
    public interface IComponent
    {
       Type ItemType { get; }
       object GetItem(int id);
    }
}