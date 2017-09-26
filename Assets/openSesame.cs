using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openSesame : MonoBehaviour {

    public bool opening = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void moveDown()
    {
        opening = true;

    }

	void Update () {

        if (opening)
        {
            transform.Translate(0, -Time.deltaTime * 2, 0);
 
;        }
	}
}
