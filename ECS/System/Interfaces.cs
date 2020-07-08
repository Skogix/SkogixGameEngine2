namespace ECS
{
    public interface ISystem{}

    public interface IInitSystem : ISystem
    {
        void Init();
    }

    public interface IDestroySystem : ISystem
    {
        void Destroy();
    }

    public interface IRunSystem : ISystem
    {
        void Run();
    }
}