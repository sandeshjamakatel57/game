using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomDestiny : MonoBehaviour
{
    //public int trigNum;
    public int genPos;
    //public GameObject way, shop, towncenter, end;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "npc")
        {
            genPos = Random.Range(1,5);
            
            if (genPos == 4)
            {
                this.gameObject.transform.position = new Vector3(721, 28, -475);
                
            }
            if (genPos == 3)
            {
                this.gameObject.transform.position = new Vector3(731, 28, -450);
                
            }
            if (genPos == 2)
            {
                this.gameObject.transform.position = new Vector3(765, 28, -450);
                
            }
            if (genPos == 1)
            {
                this.gameObject.transform.position = new Vector3(766, 28, -471);
                
            }

        }
    }
}
