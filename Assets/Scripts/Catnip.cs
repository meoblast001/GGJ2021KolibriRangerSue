using System;
using System.Collections.Generic;
using UnityEngine;

public class Catnip : MonoBehaviour, IEffect
{
    [SerializeField] private float _radius = 4f;
    [SerializeField] int _catnipEffectTicks = 300;
    [SerializeField] int _catnipCooldownTicks = 1000;

    [SerializeField] private int _activeTick;
    [SerializeField] private int _cooldownTick;

    private List<CatController> _catsAround = new List<CatController>();
    private List<CatController> _catsAffected = new List<CatController>();

    private bool _active;
    private bool _cooldown;
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

        _activeTick = _catnipEffectTicks;
    }

    public void Deactivate()
    {
        if (!_active)
        {
            return;
        }
        _active = false;

        GetComponent<SphereCollider>().radius = _restoreRadius;
        _catsAround.Clear();
        foreach (var cat in _catsAffected)
        {
            cat.ReleaseCatnip();
        }
        _catsAffected.Clear();

        _cooldownTick = _catnipCooldownTicks;
        _cooldown = true;
    }

    public bool IsActive()
    {
        return _active;
    }

    public bool IsCooldown()
    {
        return _cooldown;
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

        if (_catsAround.Contains(cat))
        {
            return;
        }

        _catsAround.Add(cat);
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

        _catsAround.Remove(cat);
    }

    private void FixedUpdate()
    {
        if (_active)
        {
            UpdateActive();
        }
        else
        {
            UpdateInactive();
        }
    }

    private void UpdateActive()
    {
        foreach (var cat in _catsAround)
        {
            cat.CatchCatnip();
            _catsAffected.Add(cat);
        }

        _catsAround.Clear();

        if (_activeTick > 0)
        {
            _activeTick--;
            return;
        }

        Deactivate();
    }

    private void UpdateInactive()
    {
        if (_cooldownTick > 0)
        {
            _cooldownTick--;
            return;
        }

        _cooldown = false;
    }
}
