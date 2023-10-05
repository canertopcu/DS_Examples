using System.Collections.Generic; 
using UnityEngine;

public class DictionaryController : MonoBehaviour, IObjectUpdate
{
    public PlayerType selectType = PlayerType.Elf;
    public PlayerInfo selectedPlayerInfo;


    [SerializeField]
    private SerializableDictionary<PlayerType, PlayerInfo> serializableDictionary = new SerializableDictionary<PlayerType, PlayerInfo>();

    
    void Start()
    {
        serializableDictionary .Add(PlayerType.Human, new PlayerInfo
        {
            narrative = "This player is a human.",
            speed = 5.0f,
            jumpingHeight = 2.0f,
            power = 10.0f
        });

        serializableDictionary .Add(PlayerType.Elf, new PlayerInfo
        {
            narrative = "This player is an elf.",
            speed = 7.0f,
            jumpingHeight = 3.0f,
            power = 8.0f
        }); 
    }

    
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
        if (!serializableDictionary .ContainsKey(selectType))
        {
            serializableDictionary.Add(selectType, selectedPlayerInfo); 
            Debug.Log(selectType + " is created");
        }
        else {
            serializableDictionary.GetValue(selectType);
            Debug.LogError(selectType + " is already in the dictionary!");
        }
       
    }

    public void RemoveObject()
    {
        if (serializableDictionary .ContainsKey(selectType)) {
            serializableDictionary .Remove(selectType); 
            Debug.Log(selectType + " is removed");
        }
        else
        {
            Debug.LogError(selectType + " is not in the dictionary!");
        }
    }
}
