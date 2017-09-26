using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win2 : MonoBehaviour
{

    public AudioClip clip;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
    }
}
