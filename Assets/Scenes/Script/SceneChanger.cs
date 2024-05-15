using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToFirstScene()
    {
        SceneManager.LoadScene("FirstScene", LoadSceneMode.Single);
    }

    public void ToSecondScene()
    {
       SceneManager.LoadScene(1, LoadSceneMode.Single); 
    }

    public void Quit()
    {
        Application.Quit();
    }
}
