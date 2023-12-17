> TheStatus 0.0 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheStatus : MonoBehaviour
{
    static public string Indicator;
    public static string AvatarIndicator;

    // Start is called before the first frame update
    void Start()
    {
        GameStatus();
    }

    // Update is called once per frame
    void Update()
    {

    }

    static public void GameStatus()
    {
        Indicator = "The status of the game is updated.";
        // The next is temporary (Marechaux) [must be review login status]:
        GameSettings.LoggedIn = false;
    }

    static public void NetworkStatus()
    {
        //
    }

    static public void LoginStatus()
    {
        //
    }

    static public void AvatarStatus()
    {
        if (GameSettings.Offline_Avatar == true)
        {
            GameSettings.IndicateAvatar();
            GameSettings.OfflineAvatar();

        }
        else if (GameSettings.Offline_Avatar == false)
        {
            GameSettings.IndicateAvatar();
            GameSettings.HostAvatar();
        }
    }

    static public void HostStatus()
    {
        TheStatus.Indicator = "Waiting for host.";
        Debug.Log("Waiting for host.");
        // Thread sleep until return from server.
        // Get indicator from server.
    }

    static public void ReceiveStatus()
    {

    }
}
