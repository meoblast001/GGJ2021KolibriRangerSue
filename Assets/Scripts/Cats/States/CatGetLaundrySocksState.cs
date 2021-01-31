using System;
using UnityEngine;

public class CatGetLaundrySocksState : ICatState
{
    private readonly CatController _catController;
    private readonly Action<CatState> _switchState;

    public CatGetLaundrySocksState(CatController catController, Action<CatState> switchState)
    {
        _catController = catController;
        _switchState = switchState;
    }

    public void Start()
    {
    }

    public void End()
    {
    }

    public void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        var washingMachineTrigger = other.GetComponent<WashingMachineTrigger>();
        if (washingMachineTrigger != null)
        {
            Debug.Log("Distributing socks");
            var socksCollection = SocksCollection.Singleton;
            var pair = socksCollection.DistributePair();
            foreach (var sock in pair)
                _catController.Inventory.AddSock(sock);
            _switchState(CatState.HideSocks);
        }
    }
}
