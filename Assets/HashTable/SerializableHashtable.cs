using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class SerializableHashtable<TKey,TValue> : ISerializationCallbackReceiver
{
    [SerializeField]
    private List<SerializableKeyValuePair<TKey,TValue>> serializableHashtable = new List<SerializableKeyValuePair<TKey,TValue>>();

    private Hashtable hashtable = new Hashtable();

    public void OnBeforeSerialize()
    {
        // Clear the list and add key-value pairs from the Hashtable
        serializableHashtable.Clear();
        foreach (DictionaryEntry entry in hashtable)
        {
            serializableHashtable.Add(new SerializableKeyValuePair<TKey,TValue>((TKey)entry.Key, (TValue)entry.Value));
        }
    }

    public void OnAfterDeserialize()
    {
        // Reconstruct the Hashtable from the serialized key-values
        hashtable.Clear();
        foreach (var pair in serializableHashtable)
        {
            hashtable[pair.Key] = pair.Value;
        }
    }

    public void Add(object key, object value)
    {
        hashtable[key] = value;
    }

    public bool ContainsKey(object key)
    {
        return hashtable.ContainsKey(key);
    }

    public bool Remove(object key)
    {
        if (hashtable.ContainsKey(key))
        {
            hashtable.Remove(key);
            return true;
        }
        return false;
    }

    public object this[object key]
    {
        get => hashtable[key];
        set => hashtable[key] = value;
    }

    public Hashtable GetHashtable()
    {
        return hashtable;
    }
}

[Serializable]
public class SerializableKeyValuePair<TKey,TValue>
{
    [SerializeField]
    private TKey key;
    [SerializeField]
    private TValue value;

    public TKey Key => key;
    public TValue Value => value;

    public SerializableKeyValuePair(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }
}