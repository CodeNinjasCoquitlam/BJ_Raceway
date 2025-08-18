using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CheckPoints[] checkpointArray;
    public int numOfCheckpoints;
    public int triggeredCheckPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        numOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoints").Length;

/*        if (player & CheckPoints overlaps) {
            int checkpoIndexint = Array.IndexOf(checkpointArray, currentCheckpoint);
            if (checkpointIndex == playerscurrentcheckpointint)
            {
                playerscurrentcheckpointint += 1;
            } else
            {
                //checkpoint isnt in order
            }
        }*/
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}




