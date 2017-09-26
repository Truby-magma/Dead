using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

    public GameObject player;
    public openSesame door;
    public AudioClip clip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 1f)
        {
            door.moveDown();
        }
	}
    public void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
    }

}
