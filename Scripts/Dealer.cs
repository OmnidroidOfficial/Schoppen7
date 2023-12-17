> Dealer.cs 0.0

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dealer : MonoBehaviour
{
    static public bool NewGame;
    static public bool NextGame;
    static public string DealType;
    static public bool CardsDealt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    static public void ReviewDeal()
    {
        switch (DealType)
        {
            case "Deal5":
                Deal5();
                break;
            case "Deal10":
                Deal10();
                break;
        }
    }

    static public void ReviewParticipants()
    {
        if (Table.IsHosted == true)
        {
            Participants.OnlineParticipants();
            TheStatus.GameStatus();
        }
        else if (Table.IsHosted == false)
        {
            Participants.OfflineParticipants();
            TheStatus.GameStatus();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static public void Deal5()
    {
        if (CardsDealt == false)
        {

        }
        else if (CardsDealt == true)
        {

        }
    }

    static public void Deal10()
    {
        if (CardsDealt == false)
        {

        }
        else if (CardsDealt == true)
        {

        }
    }

    static public void Observer()
    {

    }

    static public void ReviewGame()
    {
        switch (Table.IsHosted)
        {
            case true:
                if (NewGame == true)
                {
                    if (Table.IfParticipants == true)
                    {
                        Table.NewHostedGame();
                    }
                    else if (Table.IfParticipants == false)
                    {
                        TheStatus.Indicator = "There is no active game.";
                        // View Statistics.
                    }
                }
                else if (NextGame == true)
                {
                    if (Table.IfParticipants == true)
                    {
                        Table.NextHostedGame();
                    }
                    else if (Table.IfParticipants == false)
                    {
                        TheStatus.Indicator = "There is no active game.";
                        Debug.Log("There is no active game.");
                        // View Statistics.
                    }
                }
                else
                {
                    TheStatus.Indicator = "The table is empty.";
                    Debug.Log("The table is empty.");
                }
                break;
            case false:
                break;
        }    
        
    }
}
