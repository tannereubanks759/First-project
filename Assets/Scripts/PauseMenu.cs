using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public KeyCode testingKey;
    public TextMeshProUGUI testingText;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        if (GameManager.Instance != null)
        {
            GameManager.Instance.UnPauseMusic();
        }
            

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            testingText.text = "Down";
            testingText.color = Color.red;
            //Debug.Log("down");
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
            testingText.color = Color.magenta;
            //Debug.Log("hold");
        }
        else if (Input.GetKeyUp(testingKey))
        {
            testingText.text = "Up";
            testingText.color = Color.yellow;
            //Debug.Log("up");
        }
        else
        {
            //nothing
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
        
    }
    public void TogglePauseGame()
    {
        //pause time
        isPaused = !isPaused;

        //menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0f;
            //GameManager.Instance.audio.pitch = 0f;
            GameManager.Instance.PauseMusic();
        }
        else
        {
            Time.timeScale = 1f;
            //GameManager.Instance.audio.pitch = 1f;
            GameManager.Instance.UnPauseMusic();
        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void PlaySound(AudioClip clip)
    {
        GameManager.Instance.audio.PlayOneShot(clip);
    }
}
