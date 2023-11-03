using Infrastructure.Assets;
using Infrastructure.Factory;
using Infrastructure.Inputs;
using Infrastructure.SaveLoadModule;
using Infrastructure.WalletLogic;
using Plugins.MonoCache;
using Reflex.Core;
using Services.Factory;
using Services.Inputs;
using Services.SaveLoad;
using Services.Wallet;

namespace Infrastructure.Reflex
{
    public class ProjectInstaller : MonoCache, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor)
        {
            SaveLoad saveLoad = new SaveLoad();
            InputService inputService = new InputService();
            Wallet wallet = new Wallet(saveLoad);
            GameFactory gameFactory = new GameFactory(new AssetsProvider());
                
            descriptor.AddInstance(saveLoad, typeof(ISave));
            descriptor.AddInstance(inputService, typeof(IInputService));
            descriptor.AddInstance(wallet, typeof(IWallet));
            descriptor.AddInstance(gameFactory, typeof(IGameFactory));
        }
    }
}