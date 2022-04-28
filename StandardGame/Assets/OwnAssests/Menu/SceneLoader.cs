using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   

    public void LoadEasyScene()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadInsaneScene()
    {
        SceneManager.LoadScene(2);
    }
    public void QuiteGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
  
}
