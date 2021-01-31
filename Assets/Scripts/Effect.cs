using System;
using UnityEngine;

public enum EffectKind
{
    Catnip
}

public class Effect: MonoBehaviour
{
    [SerializeField] private EffectKind kind;
    public void OnEffect()
    {
        switch (kind)
        {
            case EffectKind.Catnip:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
