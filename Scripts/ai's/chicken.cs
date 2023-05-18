using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class chicken : MonoBehaviour
{
    public GameObject Player;
    //PLayer's value

    public float EnemyDistanceRun = 5f;
    //Radius for enemy to came


    private NavMeshAgent chick;

    
    
    void Start()
    {
        chick = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            chick.SetDestination(newPos);
        }
    }
}
