using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DMG : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        
	}

    private void OnTriggerEnter(Collider other)
    {
        Life p = other.GetComponent<Life>();
        if (p != null) p.TakeDamage();

        if (p.playerLife <= 0)
        {
            SceneManager.LoadScene("gameover", LoadSceneMode.Single);
        }
    }
}
