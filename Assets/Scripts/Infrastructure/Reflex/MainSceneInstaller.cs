using Plugins.MonoCache;
using Reflex.Core;
using Services.Factory;
using Services.Inputs;
using Services.SaveLoad;
using Services.Wallet;

namespace Infrastructure.Reflex
{
    public class MainSceneInstaller : MonoCache, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor) =>
            descriptor.OnContainerBuilt += LoadLevel;

        private void LoadLevel(Container container)
        {
            ISave save = container.Single<ISave>();
            IInputService input = container.Single<IInputService>();
            IWallet wallet = container.Single<IWallet>();
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