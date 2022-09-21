using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    //the header of a function
    //this function takes no arguments
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
