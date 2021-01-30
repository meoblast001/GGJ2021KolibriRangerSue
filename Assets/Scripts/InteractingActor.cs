using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InteractingActor : MonoBehaviour
{
    [SerializeField] private Transform LeftHandTransform;
    [SerializeField] private Transform RightHandTransform;
    [SerializeField] private InteractableObject leftHandObject;
    [SerializeField] private CollisionDetector[] collisionDetectors;

    private readonly List<Collider> _colliders = new List<Collider>();

    private bool IsCollidingWithWalls => collisionDetectors.Any(detector => detector.IsColliding);

    private void OnTriggerEnter(Collider other)
    {
        _colliders.Add(other);
    }

    private void OnTriggerExit(Collider other)
    {
        _colliders.Remove(other);
    }

    public void Interact()
    {
        if (leftHandObject == null)
        {
            TryGrabLeftHandObject();
        }
    }

    public void Throw()
    {
        if (leftHandObject != null)
        {
            ThrowLeftHandObject();
        }
    }

    private void TryGrabLeftHandObject()
    {
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

    private void ThrowLeftHandObject()
    {
        var objectToThrow = leftHandObject;
        leftHandObject = null;
        _colliders.Remove(objectToThrow.GetComponent<Collider>());

        var objectPos = objectToThrow.transform.position;

        Vector3 speed;
        Vector3 newObjectPos;

        if (IsCollidingWithWalls)
        {
            var actorPos = transform.position;
            newObjectPos = new Vector3(actorPos.x, objectPos.y, actorPos.z);
            speed = Vector3.zero;
        }
        else
        {
            var forward = LeftHandTransform.forward;
            newObjectPos = objectPos + forward * -0.2f;
            speed = new Vector3(forward.x, 1f, forward.z).normalized * 5f;
        }

        objectToThrow.transform.position = newObjectPos;
        objectToThrow.StartThrow(speed);
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
