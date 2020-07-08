using NotImplementedException = System.NotImplementedException;

namespace ECS
{
    public class Filter<In1> : Filter where In1 : struct
    {
        public override void OnAddEntity(in Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void OnRemoveEntity(in Entity entity)
        {
            throw new NotImplementedException();
        }
    }
    
    public class Filter<In1, In2> : Filter where In1 : struct where In2 : struct
    {
        public override void OnAddEntity(in Entity entity)
        {
            throw new NotImplementedException();
        }

        public override void OnRemoveEntity(in Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}