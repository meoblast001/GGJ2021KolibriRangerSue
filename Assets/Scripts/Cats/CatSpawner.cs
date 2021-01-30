using UnityEngine;
using NaughtyAttributes;

public class CatSpawner : MonoBehaviour
{
    [SerializeField] GameObject _catPrefab;
    [SerializeField] [ReorderableList] CatConfig[] _catConfigs;

    private void Start()
    {
        foreach (var catConfig in _catConfigs)
        {
            var catObject = GameObject.Instantiate(_catPrefab);
            var cat = catObject.GetComponent<CatController>();
            cat.Config = catConfig;
        }
    }
}
