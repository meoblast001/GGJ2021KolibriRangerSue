using System;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    private readonly List<Wall> _walls = new List<Wall>();

    private void OnCollisionEnter(Collision other)
    {
        OnTriggerEnter(other.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        var wall = other.GetComponent<Wall>();
        if (wall == null)
        {
            return;
        }

        _walls.Add(wall);
    }

    private void OnCollisionExit(Collision other)
    {
        OnTriggerExit(other.collider);
    }

    private void OnTriggerExit(Collider other)
    {
        var wall = other.GetComponent<Wall>();
        if (wall == null)
        {
            return;
        }

        _walls.Remove(wall);
    }

    public bool IsColliding => _walls.Count > 0;
}
