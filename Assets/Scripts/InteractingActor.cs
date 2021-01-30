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
    [SerializeField] private float throwVerticalComponent = 1.0f;
    [SerializeField] private float throwSpeed = 5.0f;

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

        Vector3 speed;

        if (IsCollidingWithWalls)
        {
            var actorPos = transform.position;
            var objectPos = objectToThrow.transform.position;
            objectToThrow.transform.position = new Vector3(actorPos.x, objectPos.y, actorPos.z);
            speed = Vector3.zero;
        }
        else
        {
            var forward = LeftHandTransform.forward;
            speed = new Vector3(forward.x, throwVerticalComponent, forward.z).normalized * throwSpeed;
        }

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
