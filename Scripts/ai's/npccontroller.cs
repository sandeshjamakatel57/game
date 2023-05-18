using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npccontroller : MonoBehaviour
{

    public float stopDistance;
    public Vector3 destination;
    public float movementspeed;
    public float rotationSpeed;
    public bool ReachedDestination;

    void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != destination)
        {
            Vector3 destinationDirection = destination - transform.position;
            destinationDirection.y = 0;

            float destinationDistance = destinationDirection.magnitude;
            
            if(destinationDistance >= stopDistance)
            {
                ReachedDestination = false;
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * movementspeed * Time.deltaTime);
            }
            else
            {
                ReachedDestination = true;
            }
            
           
        }
    }

    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        ReachedDestination = false;
    }
}
