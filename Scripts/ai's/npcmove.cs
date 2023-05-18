using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcmove : MonoBehaviour
{
    public bool reacheddestination;
    public npccontroller npccontroller;
    public waypoint currentWaypoint;

    // Start is called before the first frame update
    
    void Awake()
    {
        npccontroller = GetComponent<npccontroller>();
    }
    
    
    void Start()
    {
        npccontroller.SetDestination(currentWaypoint.GetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
