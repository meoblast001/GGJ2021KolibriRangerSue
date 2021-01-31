using System;
using UnityEngine;

public enum EffectKind
{
    Catnip
}

public interface IEffect
{
    void Activate();
    void Deactivate();
}

public class Effect: MonoBehaviour
{
    [SerializeField] private EffectKind kind;
    [SerializeField] private GameObject gameObject;

    public IEffect GetEffect()
    {
        switch (kind)
        {
            case EffectKind.Catnip: return gameObject.GetComponent<Catnip>();
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
