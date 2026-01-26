using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodyIsAGamerAndDIESifHetouchesGrass : MonoBehaviour
{
    public CheckPoints checkyScript;
    public ForceFieldPowerup forcefieldscrippy;
    
    // Start is called before the first frame update
    
    void OnCollisionEnter(Collision objectdatgothit)
    {
        if (objectdatgothit.gameObject.tag == "DIE" && forcefieldscrippy.Forcefieldactive == false)
        {
            checkyScript.CodyReset();
        }
    }
    

  
}
