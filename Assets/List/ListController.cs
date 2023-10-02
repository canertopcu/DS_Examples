using System;
using UnityEngine;
using System.Collections.Generic;

public class ListController : MonoBehaviour
{
    public string[] Players;
    public List<GameObject> objectsToMove = new List<GameObject>(); 
      
    private void Start()
    {
        int numberOfObjects = 5;

        for (int i = 0; i < numberOfObjects; i++)
        {
            GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            newObj.transform.position = new Vector3(0, i, UnityEngine.Random.Range(-1f, 1f));
            newObj.transform.name = "MovingObject_" + i;
            objectsToMove.Add(newObj); // Add the new object to the List.
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            int index = objectsToMove.Count; // Use Count property instead of Length.
            newObj.transform.position = new Vector3(0, index, UnityEngine.Random.Range(-1f, 1f));
            newObj.transform.name = "MovingObject_" + index;
            objectsToMove.Add(newObj); // Add the new object to the List.
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            int count = objectsToMove.Count; // Use Count property instead of Length.
            if (count > 0)
            {
                Destroy(objectsToMove[count - 1]);
                objectsToMove.RemoveAt(count - 1); // Remove the last object from the List.
            }
        }
    }
}