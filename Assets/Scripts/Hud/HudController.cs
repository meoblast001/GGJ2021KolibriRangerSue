using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HudController : MonoBehaviour
{
    [SerializeField] private Text _sockInventoryText;

    private IDisposable inventorySubscription;

    private int SockInventory
    {
        set => _sockInventoryText.text = $"{value} / 2";
    }

    private void Start()
    {
        var sockCollection = SocksCollection.Singleton;
        inventorySubscription = sockCollection.ObserveCountByState(SockState.WithPlayer)
            .Subscribe(count => SockInventory = count);
    }

    private void OnDestroy()
    {
        inventorySubscription.Dispose();
    }
}
