using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] npc;
    //npc's entry
   
    public Transform[] area;

    public int areanum;

    public int npcNo=0;

    public int npccount = 0;

    public int spawneeNum = 0;

    public int spawnernum;

    private float repeatRate = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            if (spawnernum == this.spawnernum)
            {
                StartCoroutine(Spawner());
            }
            //this.gameObject.SetActive(true);
            //this.gameObject.GetComponent<Capsule>().enabled = true;
        }
        
    
    }

   

   
        IEnumerator Spawner()
    {

        while (npcNo < npccount )
        {
          // this.gameObject.GetComponent<CapsuleCollider>().enabled = false;

            //areaNo = Random.Range(0, 4);

            spawneeNum = Random.Range(0, npc.Length);

            // spawnArea = Random.Range(0, 8);

            areanum = Random.Range(0, area.Length);

            Instantiate(npc[spawneeNum], area[areanum].position, area[areanum].rotation );

            yield return new WaitForSeconds(0.1f);

           // this.gameObject.GetComponent<CapsuleCollider>().enabled = true;

            npcNo += 1;
        }
        yield return new WaitForSeconds(50f);
        npcNo = 0;

    }
}
