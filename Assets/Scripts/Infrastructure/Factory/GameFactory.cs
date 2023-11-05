using Infrastructure.Reflex;
using Services.Assests;
using Services.Factory;

namespace Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssetsProvider _assetsProvider;

        public GameFactory(IAssetsProvider assetsProvider) =>
            _assetsProvider = assetsProvider;

        public CameraOperator CreateCamera() =>
            _assetsProvider.InstantiateEntity(Constants.CameraPath)
                .GetComponent<CameraOperator>();

        public Surroundings CreateSurroundings() =>
            _assetsProvider.InstantiateEntity(Constants.SurroundingsPath)
                .GetComponent<Surroundings>();
        public Handcar CreateHandcar() =>
            _assetsProvider.InstantiateEntity(Constants.HandcarPath)
                .GetComponent<Handcar>();

        public WindowRoot CreateWindowRoot() =>
            _assetsProvider.InstantiateEntity(Constants.WindowRootPath)
                .GetComponent<WindowRoot>();

        public Pool CreatePool() =>
            _assetsProvider.InstantiateEntity(Constants.PoolPath)
                .GetComponent<Pool>();

        public Hero CreateHero() =>
            _assetsProvider.InstantiateEntity(Constants.HeroPath)
                .GetComponent<Hero>();
    }
}