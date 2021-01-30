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
        _socks = _config.SockPairsConfig.Select(config => new Sock(config)).ToList();
    }
}
