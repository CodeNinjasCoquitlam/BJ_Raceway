using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForceFieldPowerup : MonoBehaviour
{
    private GameObject Cody;
    public bool Forcefieldactive = false;
    private SelectRandomPowerUp powerupscrippy;
    private CodyIsAGamerAndDIESifHetouchesGrass grass;

    public float PowerupTime = 10f;

    // Start is called before the first frame updateasd
    void Start()
    {
        Cody = GameObject.FindGameObjectWithTag("Cody");
        powerupscrippy = Cody.GetComponent<SelectRandomPowerUp>();
        grass = Cody.GetComponent<CodyIsAGamerAndDIESifHetouchesGrass>();
    }

    // Update is called once per fram
    private void Update()
    {
        this.gameObject.transform.position = Cody.transform.position + new Vector3(0, 1.3f, 0);

        if (powerupscrippy.forcefieldactivated == true) 
        {
            Forcefieldactive = true;
            grass.ForceFieldActiveAgain = true;
            
        }
        if (Forcefieldactive == true)
        {
            StartCoroutine(WaitAndRun());
        }
    }
    

    private System.Collections.IEnumerator WaitAndRun()
    {
        yield return new WaitForSeconds(PowerupTime);
        Timer();
    }

    private void Timer()
    {
        Forcefieldactive = false;
        grass.ForceFieldActiveAgain = false;
        Destroy(this.gameObject);
        powerupscrippy.forcefieldactivated = false;
    }
}
