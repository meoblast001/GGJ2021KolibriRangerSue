using System;
using System.Collections.Generic;
using System.Linq;
using NaughtyAttributes;
using UniRx;
using UnityEngine;

public class SocksCollection : MonoBehaviour
{
    [SerializeField] private SocksConfig _config;
    [SerializeField] private GameObject _sockObjectPrefab;
    [SerializeField] [ReorderableList] private CatTargetGroup[] _catTargetGroups;

    private static SocksCollection _singleton;
    public static SocksCollection Singleton => _singleton;

    private void OnEnable() => _singleton = this;
    private void OnDisable() => _singleton = null;

    private List<Sock> _socks;
    private System.Random _random = new System.Random();

    public IReadOnlyList<Sock> Socks => _socks;

    private ReadOnlyReactiveProperty<bool> _washingMachineHasSocks;
    public IReadOnlyReactiveProperty<bool> WashingMachineHasSocks => _washingMachineHasSocks;

    private void Awake()
    {
        _socks = _config.SockPairsConfig
            .SelectMany(config => new Sock[] {new Sock(config, 0), new Sock(config, 1)})
            .ToList();
    }

    private void Start()
    {
        _washingMachineHasSocks = _socks.Select(sock => sock.State)
            .CombineLatest()
            .Select(sockStates => sockStates.Any(state => state == SockState.WashingMachine))
            .DistinctUntilChanged()
            .ToReadOnlyReactiveProperty();

        SpawnSocks(_socks);
    }

    private void OnDestroy()
    {
        _washingMachineHasSocks.Dispose();
    }

    public Sock[] DistributePair()
    {
        return _socks.Where(sock => sock.State.Value == SockState.WashingMachine).Take(2).ToArray();
    }

    public IObservable<int> ObserveCountByState(SockState state)
    {
        return _socks.Select(sock => sock.State)
            .CombineLatest()
            .Select(sockStates => sockStates.Count(sockState => sockState == state))
            .DistinctUntilChanged();
    }

    public IObservable<bool> ObserveAllInLaundry()
    {
        return _socks.Select(sock => sock.State)
            .CombineLatest()
            .Select(sockStates => sockStates.All(sockState => sockState == SockState.WashingMachine))
            .DistinctUntilChanged();
    }

    private void SpawnSocks(IEnumerable<Sock> socks)
    {
        var positions = _catTargetGroups.SelectMany(group => group.Targets).ToList();
        foreach (var sock in socks)
        {
            var positionIdx = _random.Next() % positions.Count;
            var position = positions[positionIdx];

            var gameObject = GameObject.Instantiate(_sockObjectPrefab);
            gameObject.transform.position = position;
            var sockObject = gameObject.GetComponent<SockObjectController>();
            sockObject.SetSock(sock);
        }
    }
}
