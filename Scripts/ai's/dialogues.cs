using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogues : MonoBehaviour
{
    public AudioSource[] lines;

    
    
    public int lineNumber;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(NPCVoiceover());
        }
    }

    IEnumerator NPCVoiceover()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        lineNumber = Random.Range(0, 3);
        lines[lineNumber].Play();
        yield return new WaitForSeconds(5);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
