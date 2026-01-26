using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldPowerup : MonoBehaviour
{
    private GameObject Cody;
    public bool Forcefieldactive = false;
    public SelectRandomPowerUp powerupscrippy;

    // Start is called before the first frame update
    void Start()
    {
        Cody = GameObject.FindGameObjectWithTag("Cody");
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Cody.transform.position;
        if (powerupscrippy.forcefieldactivated == true) 
        {
            Forcefieldactive = true;
        }
        if (Forcefieldactive == true)
        {
            //add timer count down from 10 seconeds that when done deletes forcefield
            Forcefieldactive = false
        }
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
