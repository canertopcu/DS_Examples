using UnityEngine;
using System.Collections.Generic;

public class GraphController : MonoBehaviour
{
    public Graph<int> myGraph;
    // Use this for initialization
    void Awake()
	{
        myGraph = new Graph<int>();
        myGraph.AddVertex(0);
        myGraph.AddVertex(1);
        myGraph.AddVertex(2);

        myGraph.AddEdge(0, 1);
        myGraph.AddEdge(1, 2);
        myGraph.AddEdge(0, 2);
 
    }

    private void Start()
    {
        Debug.Log(myGraph.verticies.Count);
        Debug.Log(myGraph.verticies[0].Count);
        Debug.Log(myGraph.verticies[1].Count);
        Debug.Log(myGraph.verticies[2].Count);
    }
}