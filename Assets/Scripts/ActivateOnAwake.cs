using UnityEngine;

public class ActivateOnAwake : MonoBehaviour
{
    public GameObject Inactive;
    void Awake()
    {
        Inactive?.SetActive(true);
    }
}
