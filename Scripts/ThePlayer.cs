> ThePlayer 0.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThePlayer : MonoBehaviour
{
    static public int AvatarIndex;
    static public Image ProfileImage;
    static public string TurnRank;
    static public bool IsHost;
    static public bool IsSpectator; 
    
    void Start()
    {

    }

    static public void UpdatePlayer()
    {

    }

    static public void UpdateHost()
    {
        if (HostedGame.Synchronizing == true)
        {
            // server communication

        }
        else
        {
            if (HostedGame.ReturnStatus == Participants.ParticipantsCount)
            {
                HostedGame.ReturnStatus = 0;
                HostedGame.Ready();
            }
            else
            {

            }
        }

    }

    static public void UpdateGuest()
    {
        // await receive guestsupdated = false => synchronizing receive data about next turn/game => 
    }
}
