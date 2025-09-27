using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pausemenushowing;
    public GameObject PauseMenuObject;
    public FinishLine finishScripy;
    // Start is called before the first frame update
    void Start()
    {
        pausemenushowing = false;
        PauseMenuObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pausemenushowing == true)
        {
            Time.timeScale = 0;
            finishScripy.HideUi();
        }
        if (pausemenushowing == false)
        {
            Time.timeScale = 1;
            finishScripy.ShowUi();
        }

        if (Input.GetKeyDown(KeyCode.J) && pausemenushowing == false)
        {
            Debug.Log("Escaped");
            PauseMenuObject.SetActive(true);
            pausemenushowing = true;
        }
        
        if (Input.GetKeyDown(KeyCode.J) && pausemenushowing == true)
        {
            PauseMenuObject.SetActive(false);
            pausemenushowing = false;
        }
    }
    public void ClikedOnPauseMenuUI()
    {
        if (pausemenushowing == false)
        {
            PauseMenuObject.SetActive(true);
            pausemenushowing = true;
        }  else
        {
            PauseMenuObject.SetActive(false);
            pausemenushowing = false;
        }
    }
}
