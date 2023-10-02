using System; 
using UnityEngine;

public class ArrayController : MonoBehaviour
{
    public string[] Players; 
    public GameObject[] objectsToMove;
  
    public int numberOfObjects = 5;

    private void Start()
    {

        objectsToMove = new GameObject[numberOfObjects];
        for (int i = 0; i < numberOfObjects; i++)
        {
            objectsToMove[i] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            objectsToMove[i].transform.position = new Vector3(0, i, UnityEngine.Random.Range(-1f, 1f));
            objectsToMove[i].transform.name = "MovingObject_" + i; 
        } 
    }

    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.A)) {
            GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            int index = objectsToMove.Length;
            newObj.transform.position = new Vector3(0, index, UnityEngine.Random.Range(-1f, 1f));
            newObj.transform.name = "MovingObject_" + index;
            AddObjectToArray(ref objectsToMove, newObj);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            int length = objectsToMove.Length;
            if (length>0)
            {
                Destroy(objectsToMove[length - 1]);
                RemoveLastObjectFromArray(ref objectsToMove); 
            }
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

}

