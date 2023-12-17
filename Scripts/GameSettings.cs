> GameSettings.cs 0.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour 
{
    
    static public Image SelectedAvatar;
    static public int AvatarNumber = 1;
    public static bool LoggedIn;
    static public bool Offline_Avatar = true;

    static public void OfflineAvatar()
    {
        Offline_Avatar = true;
        ThePlayer.AvatarIndex = AvatarNumber;
    }

    static public void HostAvatar()
    {
        Offline_Avatar = false;
        ThePlayer.AvatarIndex = AvatarNumber;
    }

    static public void IndicateAvatar()
    {
        switch (TheStatus.AvatarIndicator)
        {
            case "E1":
                SelectedAvatar.sprite = GameInfo.AvatarImage3;
                AvatarNumber = 1;
                Statistics.SelectAvatar1Count++;
                break;
            case "E2":
                SelectedAvatar.sprite = GameInfo.AvatarImage2;
                AvatarNumber = 2;
                Statistics.SelectAvatar2Count++;
                break;
            case "E3":
                SelectedAvatar.sprite = GameInfo.AvatarImage3;
                AvatarNumber = 3;
                Statistics.SelectAvatar3Count++;
                break;
            case "E4":
                SelectedAvatar.sprite = GameInfo.AvatarImage4;
                AvatarNumber = 4;
                Statistics.SelectAvatar4Count++;
                break;
            case "E5":
                SelectedAvatar.sprite = GameInfo.AvatarImage5;
                AvatarNumber = 5;
                Statistics.SelectAvatar5Count++;
                break;
            case "E6":
                SelectedAvatar.sprite = GameInfo.AvatarImage6;
                GameSettings.AvatarNumber = 6;
                Statistics.SelectAvatar6Count++;
                break;
            case "E7":
                SelectedAvatar.sprite = GameInfo.AvatarImage7;
                GameSettings.AvatarNumber = 7;
                Statistics.SelectAvatar7Count++;
                break;
            case "E8":
                SelectedAvatar.sprite = GameInfo.AvatarImage8;
                GameSettings.AvatarNumber = 8;
                Statistics.SelectAvatar8Count++;
                break;
            case "E9":
                SelectedAvatar.sprite = GameInfo.AvatarImage9;
                GameSettings.AvatarNumber = 9;
                Statistics.SelectAvatar9Count++;
                break;
        }
    }
}
