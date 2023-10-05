using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashsetController : MonoBehaviour,IObjectUpdate
{
    public string addPlayerName;
    [SerializeField]
    private SerializableHashSet<string> UniqueUserList = new SerializableHashSet<string>();

    // Start is called before the first frame update
    void Start()
    {
        
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

    public void AddObject()
    {
        if (!UniqueUserList.Contains(addPlayerName))
        {
            UniqueUserList.Add(addPlayerName); 
        }
            
    }

    public void RemoveObject()
    {
        if (UniqueUserList.Contains(addPlayerName))
        {
            UniqueUserList.Remove(addPlayerName);
        }
    }


}
