using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CatTargetGroup : MonoBehaviour
{
    [SerializeField] private Color _color;

    private Vector3[] _targets;

    public IReadOnlyList<Vector3> Targets => _targets;

    private void Awake()
    {
        _targets = GetComponentsInChildren<Transform>()
            .Where(transform => transform.gameObject != gameObject)
            .Select(transform => transform.position).ToArray();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        var childTransforms = GetComponentsInChildren<Transform>()
            .Where(transform => transform.gameObject != gameObject);
        foreach (var transform in childTransforms)
            Gizmos.DrawWireCube(transform.position, Vector3.one * 0.25f);
    }
}
