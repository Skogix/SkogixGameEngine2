namespace ECS
{
    public interface IFilterListener
    {
        void OnEntityAdded(in Entity entity);
        void OnEntityRemoved(in Entity entity);
    }
}