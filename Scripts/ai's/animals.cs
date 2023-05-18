using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class animals : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 wanderPoint;
    public float wanderRadius = 8f;
    public GameObject destinationPoint;
    //AI's movements

    private bool isAware = false;
    //AI's animations

    private NavMeshAgent living;
    // AI's names


    
    
    

    void Start()
    {
        living = GetComponent<NavMeshAgent>();
        wanderPoint = RandomWanderPoint();
    }

    // Update is called once per frame
    void Update()
    {

        //living.SetDestination(destinationPoint.transform.position);
       StartCoroutine (Wander());
    }
    IEnumerator Wander()
    {
        if(Vector3.Distance(transform.position, wanderPoint) < 1f)
        {
            yield return new WaitForSeconds(10);
            wanderPoint = RandomWanderPoint();
        }
        
        else
        {
            living.SetDestination(wanderPoint);
        }
    }
    public Vector3 RandomWanderPoint()
    {
        Vector3 randomPoint = (Random.insideUnitSphere * wanderRadius) + transform.position;
        NavMeshHit navHit;
        NavMesh.SamplePosition(randomPoint, out navHit, wanderRadius, -1);
        return new Vector3(navHit.position.x, transform.position.y, navHit.position.z);
    }

    private void OnTriggerEnter(Collider col)
    {

    }
}
