using System;
using UnityEngine;
using System.Collections.Generic;

public class ListController : MonoBehaviour, IObjectUpdate
{
    public List<string> Players = new List<string>();
    public List<GameObject> objectPool = new List<GameObject>();

    public void AddObject()
    {
        GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        int index = objectPool.Count;
        newObj.transform.position = new Vector3(0, index, 0);
        newObj.transform.name = "MovingObject_" + index;
        objectPool.Add(newObj);
    }

    public void RemoveObject()
    {
        int count = objectPool.Count;
        if (count > 0)
        {
            Destroy(objectPool[count - 1]);
            objectPool.RemoveAt(count - 1);
        }
    }

    private void Start()
    { 
        Players.Add("John");
        Players.Add("Michael");
        Players.Add("Jessica");
        Players.Add("Nora");

        foreach (var p in Players)
        {
            Debug.LogError(p);
        }


        int numberOfObjects = 5;

        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newObj.transform.position = new Vector3(0, i, 0);
            newObj.transform.name = "MovingObject_" + i;
            objectPool.Add(newObj);
        }
    }

    private void Update()
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
}