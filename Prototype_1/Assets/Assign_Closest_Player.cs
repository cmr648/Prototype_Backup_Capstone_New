using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;
using UnityEngine.AI;

public class Assign_Closest_Player : MonoBehaviour
{
    public GameObject Closest_Enemy;

    public GameObject[] Players;

    public bool Holding_Trophy;

    public GameObject Trophy;

    [SerializeField]
    public AIDestinationSetter My_Destition_Setter;

    // Start is called before the first frame update
    void Start()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
        My_Destition_Setter = GetComponent<AIDestinationSetter>();
        Trophy = GameObject.FindGameObjectWithTag("Trophy");
    }

    // Update is called once per frame
    void Update()
    {
        Holding_Trophy = Trophy.GetComponent<Trophy_Timer>().Holding_Trophy;

        Look();

        if(Holding_Trophy == true)
        {
            My_Destition_Setter.target = Trophy.transform.parent;
        }
        else
        {
            My_Destition_Setter.target = Closest_Enemy.transform;

        }

    }

    void Look()
    {
        // for greatest distance
        float Distance_To_Closest = Mathf.Infinity;



        foreach (GameObject Next_Player in Players)
        {
            float Distance_To_Player = (Next_Player.transform.position - transform.position).sqrMagnitude;

            if (Next_Player.GetComponent<Player_Health>().Player_Alive == true)
            {
                if (Distance_To_Player < Distance_To_Closest)
                {
                    Distance_To_Closest = Distance_To_Player;
                    Closest_Enemy = Next_Player;
                }
            }


           

        }


    }
}
