using System;
using System.Collections.Generic;
using UnityEngine;

public class Catnip : MonoBehaviour, IEffect
{
    [SerializeField] private float _radius = 4f;

    private List<CatController> _cats = new List<CatController>();

    private bool _active;
    private float _restoreRadius;

    public void Activate()
    {
        if (_active)
        {
            return;
        }
        _active = true;

        var sphereCollider = GetComponent<SphereCollider>();
        _restoreRadius = sphereCollider.radius;
        sphereCollider.radius = _radius;
    }

    public void Deactivate()
    {
        if (!_active)
        {
            return;
        }
        _active = false;

        GetComponent<SphereCollider>().radius = _restoreRadius;
        _cats.Clear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!_active)
        {
            return;
        }

        var cat = other.GetComponent<CatController>();
        if (cat == null)
        {
            return;
        }

        if (_cats.Contains(cat))
        {
            return;
        }

        _cats.Add(cat);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!_active)
        {
            return;
        }

        var cat = other.GetComponent<CatController>();
        if (cat == null)
        {
            return;
        }

        cat.ReleaseCatnip();

        _cats.Remove(cat);
    }

    private void FixedUpdate()
    {
        if (!_active)
        {
            return;
        }

        foreach (var cat in _cats)
        {
            cat.CatchCatnip();
        }

        _cats.Clear();
    }
}
