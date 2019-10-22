using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Conditions : MonoBehaviour
{
    public bool Boss_Defeated;
    public bool Score_Cap_Reached;
    public bool Tresure_Held;

    public bool Both_Players_Dead;

    public GameObject Boss;

    public Treasure_Points My_Treasure_Points;

    public float Win_Score;

    public Trophy_Timer My_Trophy_Timer;

    public GameObject[] Players;

    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if(Boss.gameObject == null)
        {
            Boss_Defeated = true;
        }

        if(My_Treasure_Points.Score >= Win_Score)
        {
            Score_Cap_Reached = true;
        }

        if(My_Trophy_Timer.Current_Time_Amount <= 0)
        {
            Tresure_Held = true;
        }

       if(Players[0].GetComponent<Player_Health>().Player_Alive == false && Players[1].GetComponent<Player_Health>().Player_Alive == false)
        {
            Both_Players_Dead = true;
        }
    }
}
