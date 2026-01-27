using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
    
    
    //3 only 1 force field in a game at a ti    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && chosenPowerUp != null ) 
        {
            if (randomNumberInList < 2)
            {
                Instantiate(chosenPowerUp, transform.position + transform.forward * 1.5f, transform.rotation);
                chosenPowerUp = null;
            }

            if (forcefieldactivated == false && randomNumberInList == 2)
            {
                Instantiate(chosenPowerUp, transform.position + transform.forward * 1.5f, transform.rotation);
                Debug.Log(chosenPowerUp.ToString());

                if (chosenPowerUp.ToString() == "ForceField1 (UnityEngine.GameObject)")
                {
                    forcefieldactivated = true;
                }
                chosenPowerUp = null;

            }
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
