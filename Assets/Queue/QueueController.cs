using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//First IN First OUT=FIFO
public class QueueController : MonoBehaviour, IObjectUpdate
{
    public Queue<string> Players = new Queue<string>();
    public Queue<GameObject> objectPool = new Queue<GameObject>();

    //Start is called before the first frame updater
    void Start()
    { 
        Players.Enqueue("John");
        Players.Enqueue("Michael");
        Players.Enqueue("Jessica");
        Players.Enqueue("Nora");

        foreach (var p in Players)
        {
            Debug.LogError(p);
        }

        string value = "";
        while (Players.TryDequeue(out value))
        {
            Debug.LogError(value);
        }
    }

    int highestIndex = 0;
    // Update is called once per frame
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

    public void AddObject()
    {
        GameObject newObj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        int objCount = objectPool.Count;
        if (objCount == 0)
        {
            highestIndex = 0;
        }
        else if (objCount > 0)
        {

            int i = 0;
            foreach (var item in objectPool)
            {
                item.transform.position = new Vector3(0, i, 0);
                i++;
            }
        }

        newObj.transform.position = new Vector3(0, objectPool.Count, 0);
        newObj.transform.name = "MovingObject_" + highestIndex;

        if (objCount > highestIndex)
        {
            highestIndex = objCount;
        }
        else
        {
            highestIndex++;
        }

        objectPool.Enqueue(newObj);
    }

    public void RemoveObject()
    {
        GameObject value;
        if (objectPool.TryDequeue(out value))
        {
            Destroy(value);

            int i = 0;
            foreach (var item in objectPool)
            {
                item.transform.position = new Vector3(0, i, 0);
                i++;
            }
        }
    }
}
