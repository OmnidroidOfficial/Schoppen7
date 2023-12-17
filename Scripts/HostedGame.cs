>HostedGame.cs 0.0

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HostedGame : MonoBehaviour
{
    static public int SequenceNumber;
    static public int ReturnStatus;
    static public string GameName;
    static public int GameID;
    static public bool Synchronizing;
    static public bool GuestsUpdated;
    static public bool HostReady;
    static public bool GuestReady;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void Synchronize()
    {
        // send confirmation to server receive confirmation if host, receive information from server send confirmation if guest. => GuestsUpdated = true
        if (ThePlayer.IsHost == true)
        {
            Synchronizing = true;
            HostReady = false;
            ThePlayer.UpdateHost();
        }
        else
        {
            Synchronizing = true;
            HostReady = false;
            ThePlayer.UpdateGuest();
        }
    }

    static public void UpdateSequences()
    {
        GuestsUpdated = false;
        if (Table.TurnType == 1)
        {

        }
        else if (Table.TurnType == 2)
        {
            while (GuestsUpdated == false)
            {
                TheStatus.HostStatus();
            }    
            
        }
        else if (Table.TurnType == 3)
        {

        }    

    }

    static public void Ready()
    {
        // Prompt ready bool to guests, Await task (for confirmation from server, count confirmations until equal to guest count then when host has confirmed guests ready (prompt based on count) return returnstatus (lobby-based divide for counting).
    }
}
