using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleReeves : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Force")
        {
            
            Destroy(this.gameObject);
        }
    }
}
