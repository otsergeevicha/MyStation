using Plugins.MonoCache;
using Reflex.Core;

namespace Infrastructure.Reflex
{
    public class ProjectInstaller : MonoCache, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor)
        {
            // SaveLoad saveLoad = new SaveLoad();
            // InputService inputService = new InputService();
            // Wallet wallet = new Wallet(saveLoad);
            // GameFactory gameFactory = new GameFactory(new AssetsProvider());
            //     
            // descriptor.AddInstance(saveLoad, typeof(ISave));
            // descriptor.AddInstance(inputService, typeof(IInputService));
            // descriptor.AddInstance(wallet, typeof(IWallet));
            // descriptor.AddInstance(gameFactory, typeof(IGameFactory));
        }
    }
}