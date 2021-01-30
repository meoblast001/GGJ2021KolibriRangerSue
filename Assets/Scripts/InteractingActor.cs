using System;
using System.Collections.Generic;
using UnityEngine;

public class InteractingActor : MonoBehaviour
{
    [SerializeField] private Transform LeftHandTransform;
    [SerializeField] private Transform RightHandTransform;
    [SerializeField] private InteractableObject leftHandObject;

    private readonly List<Collider> _colliders = new List<Collider>();

    private void OnTriggerEnter(Collider other)
    {
        _colliders.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        _colliders.Remove(other);
    }

    public void TryToGrab()
    {
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

            if (interactable.CanBeGrabbed())
            {
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

    public void Update()
    {
        if (leftHandObject == null)
        {
            return;
        }

        leftHandObject.transform.position = LeftHandTransform.position;
    }
}
