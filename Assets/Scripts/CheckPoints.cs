using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public GameManager manage;
    private GameObject NextCheckpoint;
    public int CurrentCheckpoint;
    private Vector3 Spawn;
    private Quaternion SpawnRot;

   
    void Start()
    {
        NextCheckpoint = manage.checkpointArray[0];
    }
    public void OnTriggerEnter(Collider other)   
    {
        
        if (other.gameObject.tag == "checkpoints")
        {
            if (other.gameObject == NextCheckpoint)
            {
                Spawn = NextCheckpoint.transform.position;
                SpawnRot = this.transform.rotation;
                CurrentCheckpoint++;
                NextCheckpoint = manage.checkpointArray[CurrentCheckpoint];
                Destroy(other.gameObject);
            } else
            {
                CodyReset();
            }
            
            
        }
    }
    public void CodyReset()
    {
        this.transform.position = Spawn;
        this.transform.rotation = SpawnRot;
    }
}

