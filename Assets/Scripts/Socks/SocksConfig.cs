using UnityEngine;
using NaughtyAttributes;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "SocksConfig.asset", menuName = "Config/SocksConfig")]
public class SocksConfig : ScriptableObject
{
    [SerializeField] [ReorderableList] private SockPairConfig[] _sockPairsConfig;

    public IReadOnlyList<SockPairConfig> SockPairsConfig => _sockPairsConfig;
}
