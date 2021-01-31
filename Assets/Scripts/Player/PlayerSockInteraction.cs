using UnityEngine;

public class PlayerSockInteraction : MonoBehaviour
{
    private SockInventory _inventory;
    private SockObjectController _currentSock;
    private bool _atWashingMachine = false;

    private void Awake()
    {
        _inventory = new SockInventory();
    }

    private void OnTriggerEnter(Collider other)
    {
        var sockObject = other.GetComponent<SockObjectController>();
        if (sockObject != null)
            _currentSock = sockObject;

        if (other.GetComponent<WashingMachineTrigger>() != null)
            _atWashingMachine = true;
    }

    private void OnTriggerExit(Collider other)
    {
        var sockObject = other.GetComponent<SockObjectController>();
        if (sockObject != null)
            _currentSock = null;

        if (other.GetComponent<WashingMachineTrigger>() != null)
            _atWashingMachine = false;
    }

    public void PickUpSock()
    {
        if (_currentSock != null)
        {
            var sock = _currentSock.Sock;
            if (_inventory.AddSock(sock))
            {
                Debug.Log("Player picked up sock");
                sock.State.Value = SockState.WithPlayer;
                GameObject.Destroy(_currentSock.gameObject);
            }
            else
            {
                Debug.Log("Can not not pick up sock");
            }
        }
        else
        {
            Debug.Log("No sock to pick up");
        }
    }

    public void DropSocks()
    {
        if (_atWashingMachine)
        {
            var droppedSocks = _inventory.DropAllSocks();
            foreach (var sock in droppedSocks)
                sock.State.Value = SockState.WashingMachine;
        }
    }
}
