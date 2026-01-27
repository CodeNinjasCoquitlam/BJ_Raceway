using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodyIsAGamerAndDIESifHetouchesGrass : MonoBehaviour
{
    public CheckPoints checkyScript;
    public ForceFieldPowerup forcefieldscrippy;

    public bool ForceFieldActiveAgain;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {

    }
    void OnCollisionEnter(Collision objectdatgothit)
    {
        if (objectdatgothit.gameObject.tag == "DIE" && ForceFieldActiveAgain == false)
        {
            checkyScript.CodyReset();
        }
    }
    

  
}
