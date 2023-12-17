> TheGame.cs 0.0

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TheGame : MonoBehaviour
{

    static public bool HasSpectators;
    // Start is called before the first frame update
    void Start()
    {
        ReviewTable();
    }

    static public void ReviewTable()
    {
        if (Table.IsEmpty == true)
        {
            Dealer.ReviewGame();
        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateTurns()
    {
        if (Dealer.DealType == "Deal5")
        {
            switch (Table.NextTurnRank)
            {
                case "First":
                    Table.NextTurnRank = "Second";
                    break;
                case "Second":
                    Table.NextTurnRank = "Third";
                    break;
                case "Third":
                    Table.NextTurnRank = "Fourth";
                    break;
                case "Fourth":
                    Table.NextTurnRank = "Fifth";
                    break;
                case "Fifth":
                    Table.NextTurnRank = "First";
                    break;
            }
        }
        if (Dealer.DealType == "Deal10")
        {
            switch (Table.NextTurnRank)
            {
                case "First":
                    Table.NextTurnRank = "Second";
                    break;
                case "Second":
                    Table.NextTurnRank = "Third";
                    break;
                case "Third":
                    Table.NextTurnRank = "Fourth";
                    break;
                case "Fourth":
                    Table.NextTurnRank = "Fifth";
                    break;
                case "Fifth":
                    Table.NextTurnRank = "Sixth";
                    break;
                case "Sixth":
                    Table.NextTurnRank = "Seventh";
                    break;
                case "Seventh":
                    Table.NextTurnRank = "Eighth";
                    break;
                case "Eighth":
                    Table.NextTurnRank = "Ninth";
                    break;
                case "Ninth":
                    Table.NextTurnRank = "Tenth";
                    break;
                case "Tenth":
                    Table.NextTurnRank = "First";
                    break;
            }
        }
    }

    static public void GetHostedTurnData()
    {
        // New round
        switch (Table.HostedTurnType)
        {
            case 1:
                //use lobby name, receive game ID + status data (Hands)
                break;
            case 2:
                //Convert hands data from server to table updates
                break;
            case 3:
                //Receive game statistics from serer & data about next round (guests confirm --> dealer to assignment of players to hands)
                break;
        }
    }

    static public void SetHostedTurnData()
    {
        // End of round
        switch (Table.HostedTurnType)
        {
            case 1:
                //Hands.HostedFirstly, update UI (await server data)
                break;
            case 2:
                //Hands.HostedSecondly, update UI (await server data)
                break;
            case 3:
                //Hands.HostedThirdly, update UI (await server data)
                break;
        }
    }
}
