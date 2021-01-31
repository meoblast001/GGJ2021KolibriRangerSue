using System;
using System.Collections.Generic;
using System.Linq;
using UniRx;
using UnityEngine;

public class SocksCollection : MonoBehaviour
{
    [SerializeField] private SocksConfig _config;

    private static SocksCollection _singleton;
    public static SocksCollection Singleton => _singleton;

    private void OnEnable() => _singleton = this;
    private void OnDisable() => _singleton = null;

    private List<Sock> _socks;

    private ReadOnlyReactiveProperty<bool> _washingMachineHasSocks;
    public IReadOnlyReactiveProperty<bool> WashingMachineHasSocks => _washingMachineHasSocks;

    private void Start()
    {
        _socks = _config.SockPairsConfig
            .SelectMany(config => new Sock[] {new Sock(config, 0), new Sock(config, 1)})
            .ToList();
        _washingMachineHasSocks = _socks.Select(sock => sock.State)
            .CombineLatest()
            .Select(sockStates => sockStates.Any(state => state == SockState.WashingMachine))
            .DistinctUntilChanged()
            .ToReadOnlyReactiveProperty();
    }

    private void OnDestroy()
    {
        _washingMachineHasSocks.Dispose();
    }

    public Sock[] DistributePair()
    {
        return _socks.Where(sock => sock.State.Value == SockState.WashingMachine).Take(2).ToArray();
    }
}
