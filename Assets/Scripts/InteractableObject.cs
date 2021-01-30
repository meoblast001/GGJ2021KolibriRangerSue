using UnityEngine;

public class InteractableObject: MonoBehaviour {

    public bool CanBeGrabbed()
    {
        return true;
    }

    public bool CanBeStored()
    {
        return false;
    }
}