using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agonySound : MonoBehaviour {
    public AudioClip clip;
	// Use this for initialization
	void Start () {

        GetComponent<AudioSource>().PlayOneShot(clip);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
