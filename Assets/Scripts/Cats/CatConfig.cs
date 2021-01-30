using System;
using UnityEngine;

[Serializable]
public class CatConfig
{
    [SerializeField] private Transform _spawnPosition;

    public Vector3 SpawnPosition => _spawnPosition.position;
}
