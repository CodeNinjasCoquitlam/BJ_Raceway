using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodyIsAGamerAndDIESifHetouchesGrass : MonoBehaviour
{
    public GameObject codyDieUI;
    public GameObject Cody;
    public GameManager gameManager;
    public int codeyCheckpointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        codyDieUI.SetActive(false);
    }
    void OnCollisionEnter(Collision objectdatgothit)
    {
        if (objectdatgothit.gameObject.tag == "DIE")
        {
            CodyDIE();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void CodyDIE()
    {
        codyDieUI.SetActive(true);
        Cody.SetActive(false);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkpoints")
        {
            if (other.TryGetComponent<CheckPoints>(out CheckPoints thisCheckPoint)) {
                int currentCheckpointIndex = Array.IndexOf(gameManager.checkpointArray, thisCheckPoint);
                if (currentCheckpointIndex == codeyCheckpointIndex)
                {
                    codeyCheckpointIndex++;
                }
                else
                {
                    //not in order
                }
            }
        }
    }*/
}
