using Infrastructure.Factory;
using Infrastructure.Reflex;

namespace Services.Factory
{
    public interface IGameFactory
    {
        CameraOperator CreateCamera();
        Surroundings CreateSurroundings();
        Handcar CreateHandcar();
        WindowRoot CreateWindowRoot();
        Pool CreatePool();
        Hero CreateHero();
    }
}