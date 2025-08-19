using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public CheckPoints check;
    public GameObject WenScren;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish" && check.CurrentCheckpoint == 26)
        {
            YouWIN();
        } else if (other.gameObject.tag == "Finish")
        {
            check.CodyReset();
        }
    }
    public void YouWIN()
    {
        this.gameObject.SetActive(false);
        WenScren.SetActive(true);
    }
    void Start()
    {
        this.gameObject.SetActive(true);
        WenScren.SetActive(false);
    }

}
