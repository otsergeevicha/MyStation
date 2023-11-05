using Plugins.MonoCache;
using UnityEngine;

public class Handcar : MonoCache
{
    [HideInInspector] [SerializeField] private SpawnPointHero _spawnPointHero;

    private void OnValidate() => 
        _spawnPointHero = ChildrenGet<SpawnPointHero>();

    public Vector3 GetSpawnPointHero =>
        _spawnPointHero.transform.position;
}