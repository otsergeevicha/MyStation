using Plugins.MonoCache;
using Services.Factory;
using UnityEngine;

namespace Infrastructure.Reflex
{
    public class Pool : MonoCache
    {
        private IGameFactory _factory;

        public void Construct(IGameFactory factory, Vector3[] spawnPointsEnemies) => 
            _factory = factory;
    }
}