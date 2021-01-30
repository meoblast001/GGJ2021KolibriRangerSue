using System;
using UnityEngine;

[Serializable]
public class CatConfig
{
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private CatTargetGroup _catTargets;

    public Vector3 SpawnPosition => _spawnPosition.position;
    public CatTargetGroup CatTargets => _catTargets;
}
