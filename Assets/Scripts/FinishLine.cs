using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public CheckPoints check;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cody" && check.CurrentCheckpoint == 26)
        {
            YouWIN();
        } else
        {
            check.CodyReset();
        }
    }
    public void YouWIN()
    {

    }
}
