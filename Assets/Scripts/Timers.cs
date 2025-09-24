using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timers : MonoBehaviour
{
    public Text UrTime;
    public Text BestTime;
    public Text TimeUntilCodeyExplodes;
    public Text CountDownTillStart;

    public GameObject UrTimeObject;
    public GameObject BestTimeObject;
    public GameObject TimeUntilCodeyExplodesObject;
    public GameObject CountDownTillStartObject;

    public float totalUrTime;
    public float totalBestTime;
    public float totalTimeUntilCodeyExplodes;
    public float TheFloatForCountDownTillStart;

    public FinishLine scripy;
    public CodeyMove movescripy;

    // Start is called before the first frame update
    void Start()
    {

        UrTimeObject.SetActive(false);
        BestTimeObject.SetActive(false);
        TimeUntilCodeyExplodesObject.SetActive(false);
        CountDownTillStartObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (scripy.GameOn == false)
        {
            if (totalUrTime < totalBestTime)
            {

                PlayerPrefs.SetFloat(totalBestTime.ToString(), totalUrTime);
                totalUrTime = totalBestTime;
            }
        }
        if (scripy.GameOn == true)
        {
            
            if (TheFloatForCountDownTillStart > 0) 
            {
                TheFloatForCountDownTillStart -= Time.deltaTime;
                CountDownTillStart.text = Mathf.Round(TheFloatForCountDownTillStart).ToString();
                movescripy.Speed = 0;
            } else if (TheFloatForCountDownTillStart <= 0)
            {
                UrTimeObject.SetActive(true);
                BestTimeObject.SetActive(true);
                TimeUntilCodeyExplodesObject.SetActive(true);
                CountDownTillStartObject.SetActive(false);
                totalUrTime += Time.deltaTime;
                movescripy.Speed = 2000;

                totalTimeUntilCodeyExplodes -= Time.deltaTime;

                UrTime.text = ("Your Time:" + totalUrTime.ToString());
                TimeUntilCodeyExplodes.text = Mathf.Round(totalTimeUntilCodeyExplodes).ToString();

            }
        }
        
    }
}