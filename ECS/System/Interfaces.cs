namespace ECS
{
    public interface ISystem{}

    public interface IInitSystem : ISystem
    {
        void Init();
    }

    public interface IRunSystem : ISystem
    {
        void Run();
    }
}