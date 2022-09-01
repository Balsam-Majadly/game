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
    }

    // Update is called once per frame
    void Update()
    {
       // if (GamePaused)
         //   Time.timeScale = 0;
       // else

         //   Time.timeScale =1;

    }

    public void PauseGame()
    {
        Debug.Log("Hello: " );
        GamePaused = true;
        pausedScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        GamePaused = false;
        pausedScreen.SetActive(false);
        Time.timeScale = 1;
    }
}
