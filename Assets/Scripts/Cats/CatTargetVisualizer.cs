using UnityEngine;

public class CatTargetVisualizer : MonoBehaviour
{
    [SerializeField] private Color _color;

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        foreach (var transform in GetComponentsInChildren<Transform>())
            Gizmos.DrawWireCube(transform.position, Vector3.one * 0.25f);
    }
}
