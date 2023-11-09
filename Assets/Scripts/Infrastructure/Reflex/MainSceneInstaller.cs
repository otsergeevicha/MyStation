using Infrastructure.Factory;
using Plugins.MonoCache;
using Reflex.Core;
using Services.Factory;

namespace Infrastructure.Reflex
{
    public class MainSceneInstaller : MonoCache, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor) =>
            descriptor.OnContainerBuilt += LoadLevel;

        private void LoadLevel(Container container)
        {
            IGameFactory factory = container.Single<IGameFactory>();

            CameraOperator cameraOperator = factory.CreateCamera();
            Surroundings surroundings = factory.CreateSurroundings();
            WindowRoot windowRoot = factory.CreateWindowRoot();
            Handcar handcar = factory.CreateHandcar();
            Pool pool = factory.CreatePool();
            Hero hero = factory.CreateHero();

            pool.Construct(factory, surroundings.GetSpawnPointsEnemies());
            hero.Construct(handcar.GetSpawnPointHero);
        }
    }
}