using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawn : MonoBehaviour
{
    public GameObject[] npc;

    public int xPos;
    public int zPos;
    public int npcCount;

    public int spawnNo;

    void Start()
    {
        StartCoroutine(NPCSpawn());
    }

    IEnumerator NPCSpawn()
    {
        while (npcCount < 20)
        {
            xPos = Random.Range(724, 754);
            zPos = Random.Range(-547, -498);

            spawnNo = Random.Range(0, npc.Length);


            Instantiate(npc[spawnNo], new Vector3(xPos, 28, zPos), Quaternion.identity);

            yield return new WaitForSeconds(0.1f);

            npcCount += 1;

        }
    }

    
}
