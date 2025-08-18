using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBlockerRemover : MonoBehaviour
{
    public GameObject startBlocker;
    public GameObject endBlocker;
    // Start is called before the first frame update
    void Start()
    {
        startBlocker.SetActive(false);
        endBlocker.SetActive(true);
    }

   
    void onTriggerEnter(Collision other)
    {
        if (other.gameObject.tag == "Cody")
        {
            startBlocker.SetActive(true);
            endBlocker.SetActive(false);
        }
    }
}
