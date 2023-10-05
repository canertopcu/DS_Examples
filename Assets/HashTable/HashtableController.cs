using System.Collections;
using UnityEngine;

public class HashtableController : MonoBehaviour, IObjectUpdate
{
    public PlayerType selectType = PlayerType.Elf;
    public PlayerInfo selectedPlayerInfo;

    // Hashtable to store player information
    [SerializeField]
    private SerializableHashtable<PlayerType, PlayerInfo> playerInfoHashtable = new SerializableHashtable<PlayerType, PlayerInfo>();

    void Start()
    {
        // Add initial player information to the hashtable
        playerInfoHashtable.Add(PlayerType.Human, new PlayerInfo
        {
            narrative = "This player is a human.",
            speed = 5.0f,
            jumpingHeight = 2.0f,
            power = 10.0f
        });

        playerInfoHashtable.Add(PlayerType.Elf, new PlayerInfo
        {
            narrative = "This player is an elf.",
            speed = 7.0f,
            jumpingHeight = 3.0f,
            power = 8.0f
        });
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
        if (!playerInfoHashtable.ContainsKey(selectType))
        {
            playerInfoHashtable.Add(selectType, selectedPlayerInfo);
            Debug.Log(selectType + " is created");
        }
        else
        {
            Debug.LogError(selectType + " is already in the hashtable!");
        }
    }

    public void RemoveObject()
    {
        if (playerInfoHashtable.ContainsKey(selectType))
        {
            playerInfoHashtable.Remove(selectType);
            Debug.Log(selectType + " is removed");
        }
        else
        {
            Debug.LogError(selectType + " is not in the hashtable!");
        }
    }
}