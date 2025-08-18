using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLOADER : MonoBehaviour
{
    public string SceneToLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
