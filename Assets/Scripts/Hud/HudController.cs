using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class HudController : MonoBehaviour
{
    [SerializeField] private Text _sockInventoryText;
    [SerializeField] private Text _socksInLaundryText;

    private IDisposable _inventorySubscription;
    private IDisposable _socksInLaundrySubscription;

    private int SockInventory
    {
        set => _sockInventoryText.text = $"{value} / 2";
    }

    private void Start()
    {
        var sockCollection = SocksCollection.Singleton;
        _inventorySubscription = sockCollection.ObserveCountByState(SockState.WithPlayer)
            .Subscribe(count => SockInventory = count);
        _socksInLaundrySubscription = sockCollection.ObserveCountByState(SockState.WashingMachine)
            .Subscribe(count => SetSocksInLaundry(count, sockCollection.Socks.Count));
    }

    private void OnDestroy()
    {
        _inventorySubscription.Dispose();
    }

    private void SetSocksInLaundry(int current, int max)
    {
        _socksInLaundryText.text = $"{current} / {max}";
    }
}
