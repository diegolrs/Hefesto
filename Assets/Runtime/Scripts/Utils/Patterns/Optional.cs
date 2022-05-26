using System;
using UnityEngine;

[Serializable]
public struct Optional<T>
{
    [SerializeField] private bool _enabled;
    [SerializeField] private T _value;

    public bool Enabled => _enabled;
    public T Value => _enabled ? _value : default(T);

    public void SetValue(T value)
    {
        _enabled = true;
        _value = value;
    }

    public void DiscardValue()
    {
        _enabled = false;
        _value = default(T);
    }

    public Optional(T initialValue)
    {
        _enabled = true;
        _value = initialValue;
    }
}