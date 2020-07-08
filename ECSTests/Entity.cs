using ECS;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;

namespace ECSTests
{
    [TestFixture]
    public class Entity
    {
        private World world;
        private Entity entity;
        [SetUp]
        public void Setup()
        {
            world = new World();
            entity = new Entity();
        }

        [Test]
        public void Init()
        {
            Assert.NotNull(world);
            Assert.NotNull(entity);
        }
    }
}