using System.Collections.Generic;
using UnityEngine;

public class InteractingActor : MonoBehaviour
{
    public InteractableObject LeftHandObject;
    public Vector3 LeftHandOffset;

    private readonly List<Collider> _colliders = new List<Collider>();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        _colliders.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        _colliders.Remove(other);
    }

    public void TryToGrab()
    {
        if (LeftHandObject != null)
        {
            return;
        }

        foreach (var collider in _colliders)
        {
            var interactable = collider.GetComponent<InteractableObject>();
            if (interactable == null)
            {
                continue;
            }

            if (interactable.CanBeGrabbed())
            {
                LeftHandObject = interactable;
            } else if (interactable.CanBeStored())
            {
                Debug.Log("Stored item: " + interactable);
            }
        }
    }

    public void FixedUpdate()
    {
        if (LeftHandObject == null)
        {
            return;
        }

        LeftHandObject.transform.position = transform.position + LeftHandOffset;
    }
}
