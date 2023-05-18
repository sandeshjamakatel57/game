using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    CharacterNavigationController controller;
    public Waypoint currentWayPoint;

    private void Awake()
    {
        controller = GetComponent<CharacterNavigationController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        controller.SetDestination(currentWayPoint.GetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.reachedDestination)
        {
            currentWayPoint = currentWayPoint.nextWaypoint;
            controller.SetDestination(currentWayPoint.GetPosition());
        }
    }
}
