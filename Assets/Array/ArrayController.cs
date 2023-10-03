using System;
using UnityEngine;

public class ArrayController : MonoBehaviour, IObjectUpdate
{
    public string[] Players; 
    public GameObject[] objectPool;
  
    public int numberOfObjects = 5;

    private void Start()
    {
        Players = new string[4];
        Players[0]= "John";
        Players[1]= "Michael";
        Players[2]= "Jessica";
        Players[3]= "Nora";
               
        objectPool = new GameObject[numberOfObjects];
        for (int i = 0; i < numberOfObjects; i++)
        {
            objectPool[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            objectPool[i].transform.position = new Vector3(0, i, 0);
            objectPool[i].transform.name = "MovingObject_" + i; 
        } 
    }

    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.A)) {
            AddObject();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            RemoveObject();
        }
    }


    private void AddObjectToArray<T>(ref T[] array, T newObject)
    {
        int newSize = array.Length + 1;
        T[] newArray = new T[newSize];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }

        newArray[newArray.Length - 1] = newObject;

        array = newArray;
    }
     
    private void RemoveLastObjectFromArray<T>(ref T[] array)
    {
        int currentLength = array.Length;

        // Check if the array is empty.
        if (currentLength == 0)
        {
            return; // Nothing to remove.
        }

        // Create a new array with reduced capacity.
        int newSize = currentLength - 1;
        T[] newArray = new T[newSize];

        // Copy elements from the old array to the new one, excluding the last element.
        for (int i = 0; i < newSize; i++)
        {
            newArray[i] = array[i];
        }

        // Update the original array to the new one with reduced capacity.
        array = newArray;
    }

    public void AddObject()
    {
        GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        int index = objectPool.Length;
        newObj.transform.position = new Vector3(0, index, 0);
        newObj.transform.name = "MovingObject_" + index;
        AddObjectToArray(ref objectPool, newObj);
    }

    public void RemoveObject()
    {
        int length = objectPool.Length;
        if (length > 0)
        {
            Destroy(objectPool[length - 1]);
            RemoveLastObjectFromArray(ref objectPool);
        }
    }
}

