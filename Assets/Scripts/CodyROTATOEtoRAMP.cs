using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodyROTATOEtoRAMP : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("triggered");
        if (other.gameObject.name == "Angler X 201")
        {
            this.transform.rotation = Quaternion.Euler(-21.681f, 180f, transform.rotation.z);
        } 
        else if (other.gameObject.name == "Angler X -201")
        {
            this.transform.rotation = Quaternion.Euler(21.681f, 180f, transform.rotation.z);
        }
    }
    private void OnTriggerExit(Collider other) 
    {
        Debug.Log("triggered");
        if (other.gameObject.name == "Angler X 201")
        {
            this.transform.rotation = Quaternion.Euler(0f, 180f, transform.rotation.z);
        } 
        else if (other.gameObject.name == "Angler X -201")
        {
            this.transform.rotation = Quaternion.Euler(0f, 180f, transform.rotation.z);
        }
    }
  
}
