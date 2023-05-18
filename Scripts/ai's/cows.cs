using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cows : MonoBehaviour
{
    //public Transform Player;
    public Animator anim;
    public float delayTime = 10f;
    public AudioSource audio;
    public AudioClip talks;
    void Start()
    {
        //anim = GetComponent<UnityEngine.AI.NavMeshAgent>();
       // player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player" && talks != null)
        {
            StartCoroutine(delay());
            audio.PlayOneShot(talks, 0.7f);
            anim.SetBool("get", true);
            anim.SetBool("set", false);
        }
        else
        {
            anim.SetBool("get", false);
            anim.SetBool("set", true);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        
    }
}
