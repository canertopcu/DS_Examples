using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Graph<T>
{
    public Dictionary<T, List<T>> verticies;

    public Graph()
    {
        verticies = new Dictionary<T, List<T>>();
    }

    public void AddVertex(T vertex)
    {
        if (!verticies.ContainsKey(vertex))
        {
            verticies[vertex] = new List<T>();
        }
    }

    public void AddEdge(T source, T destination)
    {
        if (verticies.ContainsKey(source) && verticies.ContainsKey(destination))
        {
            verticies[source].Add(destination);
            verticies[destination].Add(source); // For an undirected graph
        }
        else
        {
            Debug.LogError("Vertex not found in the graph");
        }
    }
}