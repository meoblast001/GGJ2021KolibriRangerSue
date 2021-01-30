using UnityEngine;

public class InteractableObject: MonoBehaviour {

    [SerializeField] private bool _canBeGrabbed;
    [SerializeField] private bool _canBeStored;

    public bool CanBeGrabbed()
    {
        return _canBeGrabbed;
    }

    public bool CanBeStored()
    {
        return _canBeStored;
    }
}