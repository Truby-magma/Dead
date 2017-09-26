using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{


    public Transform player;
    private NavMeshAgent man;


    public AudioClip clip;

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().PlayOneShot(clip);
        man = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(player);
        transform.Translate(Vector3.forward * Time.deltaTime * 4);
        man.SetDestination(player.position);

    }
}
