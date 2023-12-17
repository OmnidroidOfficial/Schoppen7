> Table 0.0

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    static public bool IsHosted;
    static public bool IsEmpty;
    static public bool IfParticipants;
    static public string NextTurnRank;
    static public int TurnType;
    static public int HostedTurnType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    static public void NewGame()
    {

    }

    static public void NextTurn()
    {
        TheStatus.Indicator = NextTurnRank + "player is next.";
        Debug.Log(NextTurnRank + "player is next.");
        TheStatus.GameStatus();
    }

    static public void NextGame()
    {

    }

    static public void NewHostedGame()
    {
        HostedTurnType = 1;
    }

    static public void NextHostedTurn()
    {
        TheStatus.Indicator = NextTurnRank + "player is next.";
        Debug.Log(NextTurnRank + "player is next.");
        TheStatus.GameStatus();
        HostedTurnType = 2;
    }

    static public void NextHostedGame()
    {
        HostedTurnType = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
