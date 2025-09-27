using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxFEATURES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /////// uhhh numero 151 in da workbook
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cody")
        {
            this.gameObject.SetActive(false);
        }
    }
}
