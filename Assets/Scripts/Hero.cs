using Plugins.MonoCache;
using UnityEngine;

public class Hero : MonoCache
{
    public void Construct(Vector3 newPositionHero) => 
        SetCurrentPosition(newPositionHero);

    private void SetCurrentPosition(Vector3 spawnPointPosition) => 
        transform.position = spawnPointPosition;
}