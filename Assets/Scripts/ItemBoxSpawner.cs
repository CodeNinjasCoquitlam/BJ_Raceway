using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxSpawner : MonoBehaviour
{
    public GameObject ItemBox;
    public int noOfBoxes;
    public GameObject spawnLocation;

    public int modXpos;
    public int modZpos;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = 0; i < noOfBoxes; i++)
        {
           GameObject ItemBoxClone = Instantiate(ItemBox, new Vector3 (spawnLocation.transform.position.x + modXpos * i, spawnLocation.transform.position.y, spawnLocation.transform.position.z + modZpos * i), spawnLocation.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
