using UnityEngine;

public class CatSpawnPoint : MonoBehaviour
{
    [SerializeField] private Color _color;

    private void OnDrawGizmos()
    {
        Gizmos.color = _color;
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
