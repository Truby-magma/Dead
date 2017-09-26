using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {

    public int playerLife = 100;
    public AudioClip clip;
    public Text txt;
    public Image image;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        txt.text = "Health: " + playerLife;
        Color c = image.color;
        c.a = c.a - 0.04f;
        image.color = c;
	}

    public void TakeDamage()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        playerLife = playerLife - 20;
        Color c = image.color;
        c.a = 1;
        image.color = c;
    }
}
