using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour {

    public Transform Zombie;
    public Animator myAnimator;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        myAnimator = GetComponent<Animator>();
        if (Vector3.Dot(transform.forward, (Zombie.position - transform.position).normalized) < 0.9f)
        {
            myAnimator.SetBool("Flash", false);
        }
        else
        {
            myAnimator.SetBool("Flash", true);
            Zombie.Translate(Vector3.zero * Time.deltaTime);
        }
	}
}
