using Plugins.MonoCache;
using UnityEngine;

public class Surroundings : MonoCache
{
    [HideInInspector] [SerializeField] private SpawnPointHandcar _spawnPointHandcar;
    [HideInInspector] [SerializeField] private SpawnPointEnemy[] _spawnPointEnemies;

    private Vector3[] _points;
    
    private void OnValidate()
    {
        _spawnPointHandcar = ChildrenGet<SpawnPointHandcar>();
        _spawnPointEnemies = ChildrenGets<SpawnPointEnemy>();
    }

    public Vector3 GetSpawnPointHandcar =>
        _spawnPointHandcar.transform.position;

    public Vector3[] GetSpawnPointsEnemies()
    {
        _points = new Vector3[_spawnPointEnemies.Length];

        for (int i = 0; i < _spawnPointEnemies.Length; i++) 
            _points[i] = _spawnPointEnemies[i].transform.position;

        return _points;
    }
}