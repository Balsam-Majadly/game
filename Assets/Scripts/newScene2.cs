using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newScene2 : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadGame()
    {
        Debug.Log("Hello: ");
        if (level == 1)
        {
            SceneManager.LoadScene("New Scene2");
        }
        if (level == 2)
        {
            SceneManager.LoadScene("New Scene3");
        }
        if (level == 3)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
