using System;
using UnityEngine;

[Serializable]
public class SockPairConfig
{
    [SerializeField] private Color _color;

    public Color Color => _color;
}
