using UnityEngine;
using System.Collections.Generic;
using System; 
using System.Linq;

[Serializable]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>
{
    public List<DictionaryElement<TKey, TValue>> serializedDictionary = new List<DictionaryElement<TKey, TValue>>();

    public SerializableDictionary() { }

    public SerializableDictionary(Dictionary<TKey, TValue> dictionary)
    {
        serializedDictionary = dictionary.Select(kv => new DictionaryElement<TKey, TValue>(kv.Key, kv.Value)).ToList();
    }

    public TValue GetValue(TKey key) {
        DictionaryElement<TKey, TValue> element = serializedDictionary.FirstOrDefault(e => EqualityComparer<TKey>.Default.Equals(e.Key, key));

        if (element != null)
        {
            return element.Value;
        }
        else
        {
            // Handle the case when the key is not found
            throw new KeyNotFoundException($"Key '{key}' not found in the dictionary.");
        }
    }

    public new void Add(TKey key, TValue value)
    {
        base.Add(key, value); // Call the base class's Add method
        serializedDictionary.Add(new DictionaryElement<TKey, TValue>(key, value));
    }

    public new bool Remove(TKey key)
    {
        if (base.Remove(key))
        {
            // Use LINQ to find the element and remove it
            serializedDictionary.RemoveAll(element => EqualityComparer<TKey>.Default.Equals(element.Key, key));
            return true;
        }

        return false;
    }

    public new void Clear()
    {
        base.Clear(); // Call the base class's Clear method
        serializedDictionary.Clear();
    }

    public Dictionary<TKey, TValue> ToDictionary()
    {
        return serializedDictionary.ToDictionary(element => element.Key, element => element.Value);
    }

    public void FromDictionary(Dictionary<TKey, TValue> dictionary)
    {
        serializedDictionary = dictionary.Select(kv => new DictionaryElement<TKey, TValue>(kv.Key, kv.Value)).ToList();
    }
}

[Serializable]
public class DictionaryElement<TKey, TValue>
{
    [SerializeField]
    private TKey key;
    public TKey Key => key;

    [SerializeField]
    private TValue value;
    public TValue Value => value;

    public DictionaryElement(TKey key, TValue value)
    {
        this.key = key;
        this.value = value;
    }

}
    