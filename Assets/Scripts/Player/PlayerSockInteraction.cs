using UnityEngine;

public class PlayerSockInteraction : MonoBehaviour
{
    private SockInventory _inventory;
    private SockObjectController _currentSock;

    private void Awake()
    {
        _inventory = new SockInventory();
    }

    private void OnTriggerEnter(Collider other)
    {
        var sockObject = other.GetComponent<SockObjectController>();
        if (sockObject != null)
            _currentSock = sockObject;
    }

    private void OnTriggerExit(Collider other)
    {
        var sockObject = other.GetComponent<SockObjectController>();
        if (sockObject != null)
            _currentSock = null;
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
}
