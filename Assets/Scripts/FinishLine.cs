using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    public CheckPoints check;
    public GameObject WenScren;
    public GameObject Timers;
    public Text UrTime;
    public Text BestTime;
    public Timers sinkytimerscripy;

    public bool GameOn;

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
        GameOn = false;
        this.gameObject.SetActive(false);
        WenScren.SetActive(true);
        Timers.SetActive(false);
        UrTime.text = ("Your Time:" + sinkytimerscripy.totalUrTime.ToString());
        BestTime.text = ("Best Time:" + sinkytimerscripy.totalBestTime.ToString());

    }
    public void Update()
    {
        if (GameOn ==  false)
        {
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }
    }
    public void HideUi()
    {
        GameOn = false;
        this.gameObject.SetActive(false);
        Timers.SetActive(false);

    }
    
    public void ShowUi()
    {
        GameOn = true;
        this.gameObject.SetActive(true);
        Timers.SetActive(true);

    }
    void Start()
    {
        this.gameObject.SetActive(true);
        WenScren.SetActive(false);
        Timers.SetActive(true);
        GameOn = true;
    }

}
