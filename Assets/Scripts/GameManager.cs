using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] checkpointArray;
    public int numOfCheckpoints;
    public int triggeredCheckPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        numOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoints").Length;


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}




