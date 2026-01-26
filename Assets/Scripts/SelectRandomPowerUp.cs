using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerUp : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerUp;
    public bool cooldown;
    public float cooldownTime;
    public bool forcefieldactivated = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerUp != null ) 
        {
            Instantiate(chosenPowerUp, transform.position + transform.forward *1.5f,transform.rotation);
            if ( randomNumberInList == 2 ) 
            { 
                forcefieldactivated = true;
            }
            chosenPowerUp = null;
            forcefieldactivated = false;

        }
    }

    private void OnTriggerEnter(Collider other) 
    {
    if (other.gameObject.tag == "itemBoxes") 
        {
            if (cooldown == false)
            {
                randomNumberInList = Random.Range(0, powerupList.Count);
                chosenPowerUp = powerupList[randomNumberInList];
            }
        }
    }

}
