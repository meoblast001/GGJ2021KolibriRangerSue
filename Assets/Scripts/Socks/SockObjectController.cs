using UnityEngine;

public class SockObjectController : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    private Sock _sock;
    public Sock Sock => _sock;

    public void SetSock(Sock sock)
    {
        _sock = sock;

        var material = _meshRenderer.materials[0];
        material.color = sock.PairConfig.Color;
        _meshRenderer.material = material;
    }
}
