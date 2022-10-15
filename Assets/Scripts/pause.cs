using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject pausedScreen;
    bool GamePaused;
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePaused==true)
        {
            Time.timeScale = 0f;
            Debug.Log(Time.timeScale );
        }
        if (GamePaused==false)
        {

            Time.timeScale = 1f;
            Debug.Log("false ");
        }

    }

    public void PauseGame()
    {
         Debug.Log("Hello: " );

        Time.timeScale = 0f;
        GamePaused = true;
        pausedScreen.SetActive(true);
        
    }

    public void ResumeGame()
    {
        GamePaused = false;
        pausedScreen.SetActive(false);
        
    }
}
