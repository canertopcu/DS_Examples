using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HashTableExample : MonoBehaviour
{
    public Hashtable ht = new Hashtable();
   
    // Start is called before the first frame update
    void Start()
    {
        ht.Add("Caner", 13);
        ht.Add(12, "Cner");
        ht.Add(1.2f, 12.54f);

        Debug.Log(ht["Caner"].GetType());
        Debug.Log(ht[12]);
        Debug.Log(ht[1.2f]); 
    }

    
}
