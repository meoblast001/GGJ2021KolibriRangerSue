using UnityEngine;

public interface ICatState
{
    void Start();
    void End();
    void Update();
    void OnTriggerEnter(Collider other);
}
