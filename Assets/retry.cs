using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retry : MonoBehaviour {

    public AudioClip clip;
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().PlayOneShot(clip);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("lvl1", LoadSceneMode.Single);
        }
	}
}
