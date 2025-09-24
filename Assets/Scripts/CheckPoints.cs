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
    private Vector3 BackUpSpawn;
    public Timers timyscripy;
    public GameObject Cody;
    public GameObject dedscren;

   void Update()
    {
        if (timyscripy.totalTimeUntilCodeyExplodes <= 0) 
        {
            CodyDYE();
        }


    }

    void Start()
    {
        NextCheckpoint = manage.checkpointArray[0];
        BackUpSpawn = new Vector3(576.87f, 21.93f, 455.98f);
        Cody.SetActive(true);
        dedscren.SetActive(false);
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
                if (CurrentCheckpoint < 26)
                {
                    NextCheckpoint = manage.checkpointArray[CurrentCheckpoint];
                }
                
                Destroy(other.gameObject);
            } else
            {
                CodyReset();
            }
            
            
        }
    }
    public void CodyReset()
    {
        if (Spawn.x == 0f)
        {
            this.transform.position = BackUpSpawn;
            this.transform.rotation = Quaternion.Euler(transform.rotation.x, 180f, transform.rotation.z);
        } else
        {
            this.transform.position = Spawn;
            this.transform.rotation = SpawnRot;
        }
        timyscripy.totalUrTime += 5;
        timyscripy.totalTimeUntilCodeyExplodes -= 5;
    }
    public void CodyDYE()
    {
        Cody.SetActive(false);
        dedscren.SetActive(true);
    }
}

