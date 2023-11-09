using Infrastructure.Assets;
using Infrastructure.Factory;
using Plugins.MonoCache;
using Reflex.Core;
using Services.Factory;

namespace Infrastructure.Reflex
{
    public class ProjectInstaller : MonoCache, IInstaller
    {
        public void InstallBindings(ContainerDescriptor descriptor)
        {
            GameFactory gameFactory = new GameFactory(new AssetsProvider());
            
            descriptor.AddInstance(gameFactory, typeof(IGameFactory));
        }
    }
}