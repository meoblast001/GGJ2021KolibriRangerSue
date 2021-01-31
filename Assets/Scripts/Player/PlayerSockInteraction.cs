using UnityEngine;

public class PlayerSockInteraction : MonoBehaviour
{
    private SockInventory _inventory;

    private void Awake()
    {
        _inventory = new SockInventory();
    }

    private void OnTriggerEnter(Collider other)
    {
        var sockObject = other.GetComponent<SockObjectController>();
        if (sockObject != null)
        {
            var sock = sockObject.Sock;
            if (_inventory.AddSock(sock))
            {
                Debug.Log("Player picked up sock");
                sock.State.Value = SockState.WithPlayer;
                GameObject.Destroy(sockObject.gameObject);
            }
        }
    }
}
