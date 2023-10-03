using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Pool;
using static UnityEditor.Progress;

//First IN Last OUT=FILO
public class StackController : MonoBehaviour,IObjectUpdate
{
    public List<string> Values;
    public Stack<string> Players = new Stack<string>();
    public Stack<GameObject> objectPool = new Stack<GameObject>();

   
    private void Start()
    { 
        Players.Push("John");
        Players.Push("Michael");
        Players.Push("Jessica");
        Players.Push("Nora");
        

        foreach (var p in Players)
        {
            Debug.LogError(p);
        }

        string value = "";
        while (Players.TryPop(out value))
        {
            Debug.LogError(value);
        }
        Values = Players.ToList();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddObject();

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RemoveObject();
        }
    }

    int highestIndex = 0;
    public void AddObject()
    {
        GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        int objCount = objectPool.Count;
        newObj.transform.position = new Vector3(0, objCount, 0);
        newObj.transform.name = "MovingObject_" + objCount; 
        objectPool.Push(newObj); 
    }

    public void RemoveObject()
    {
        if (objectPool.Count > 0)
        {
            GameObject objToRemove = objectPool.Pop();
            Destroy(objToRemove);
        }   
    }
 
}

