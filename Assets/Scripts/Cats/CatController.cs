using UnityEngine;

public class CatController : MonoBehaviour
{
    private CatConfig _catConfig;

    public CatConfig Config
    {
        set => _catConfig = value;
    }

    private void Start()
    {
        transform.position = _catConfig.SpawnPosition;
    }
}
