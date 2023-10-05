using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SerializableHashSet<T>
{
    [SerializeField]
    private List<T> elements = new List<T>();

    public SerializableHashSet() { }

    public SerializableHashSet(HashSet<T> hashSet)
    {
        elements.AddRange(hashSet);
    }

    public HashSet<T> ToHashSet()
    {
        return new HashSet<T>(elements);
    }

    public void Add(T item)
    {
        if (!elements.Contains(item))
        {
            elements.Add(item);
        }
    }

    public bool Remove(T item)
    {
        return elements.Remove(item);
    }

    public bool Contains(T item)
    {
        return elements.Contains(item);
    }
}