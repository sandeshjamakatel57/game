using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   

public class npcdestination : MonoBehaviour
{
    bool npcWaiting;
    public float waitTimer = 0f;
    public float totalWaitTime = 0f;

    public  List <Waypoints> point;

    NavMeshAgent ai;
    bool travelling;
    public int index = 0;

    void Start()
    {
        GameObject[] WaypointTag = GameObject.FindGameObjectsWithTag("Waypoints");
        point = new List<Waypoints>();
        for(int i = 0; i<WaypointTag.Length; i++)
        {
            Waypoints nextWayPoint = WaypointTag[i].GetComponent<Waypoints>();
            point.Add(nextWayPoint);
        }
        ai = this.GetComponent<NavMeshAgent>();
        index =UnityEngine.Random.Range(0, point.Count);
        SetDestination();
    }

    void Update()
    {
        if(travelling&&ai.remainingDistance <=1.0f)
        {
            travelling = false;
            npcWaiting = true;
            waitTimer = 0f;

        }
        if(npcWaiting)
        {
            waitTimer += Time.deltaTime;
            if(waitTimer >= totalWaitTime)
            {
                npcWaiting = false;
                index =UnityEngine.Random.Range(0, point.Count);
                SetDestination();
            }
        }
    }

    private void SetDestination()
    {
        Vector3 nextMove = point[index].transform.position;
        ai.SetDestination(nextMove);
        travelling = true;
    }
  
}
