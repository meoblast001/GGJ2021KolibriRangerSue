using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractingActor : MonoBehaviour
{
    [SerializeField] private InteractableObject leftHandObject;
    [SerializeField] private Vector3 leftHandOffset;

    private readonly List<Collider> _colliders = new List<Collider>();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        _colliders.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
        //_colliders.Remove(other);
    }

    public void TryToGrab()
    {
        Debug.Log("TryToGrab");

        if (leftHandObject != null)
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

            Debug.Log("InteractableObject");


            if (interactable.CanBeGrabbed())
            {
                Debug.Log("CanBeGrabbed");
                leftHandObject = interactable;
            } else if (interactable.CanBeStored())
            {
                Debug.Log("Stored item: " + interactable);
            }
            else
            {
                throw new InvalidOperationException("Should never happen");
            }
        }
    }

    public void FixedUpdate()
    {
        if (leftHandObject == null)
        {
            return;
        }

        leftHandObject.transform.position = transform.position + leftHandOffset;
    }
}
