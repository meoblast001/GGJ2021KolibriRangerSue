using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SocksCollection : MonoBehaviour
{
    [SerializeField] private SocksConfig _config;

    private static SocksCollection _singleton;
    public static SocksCollection Singleton => _singleton;

    private void OnEnable() => _singleton = this;
    private void OnDisable() => _singleton = null;

    private List<Sock> _socks;

    private void Start()
    {
        _socks = _config.SockPairsConfig
            .SelectMany(config => new Sock[] {new Sock(config, 0), new Sock(config, 1)})
            .ToList();
    }

    public Sock[] DistributePair()
    {
        return _socks.Where(sock => sock.State.Value == SockState.WashingMachine).Take(2).ToArray();
    }
}
