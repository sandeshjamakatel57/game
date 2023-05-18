using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class stag : MonoBehaviour
{
    public Transform player;
    //PLayer's value

    public float EnemyDistanceRun ;
    //Radius for enemy to came


    private UnityEngine.AI.NavMeshAgent deer;

    private Animator anim;



    void Start()
    {
        deer = GetComponent<UnityEngine.AI.NavMeshAgent>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(deer.transform.position, player.transform.position);

        if (distance < EnemyDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            anim.SetBool("isRunning", true);
            anim.SetBool("isGrazing", false);
            deer.SetDestination(newPos);


            
        }

        else
        {
            anim.SetBool("isGrazing", true);
            anim.SetBool("isRunning", false);
        }
    }
}
