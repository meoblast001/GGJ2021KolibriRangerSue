using UnityEngine;

public class SockObjectController : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;

    public void SetConfig(SockPairConfig config)
    {
        var material = _meshRenderer.materials[0];
        material.color = config.Color;
        _meshRenderer.material = material;
    }
}
