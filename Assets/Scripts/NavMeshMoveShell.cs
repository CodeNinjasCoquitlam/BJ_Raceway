using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMoveShell : MonoBehaviour
{
    private Transform goal;
    private NavMeshAgent agent;
    private GameObject goalObject;
    // Start is called before the first frame update
    void Start()
    {

        goalObject = GameObject.FindGameObjectWithTag("Obstacle");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goalObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       
       
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
