using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountdownTimer : MonoBehaviour
{
    public int level;
    float currentTime=0f;
   public float startTime;
    [SerializeField] Text countdownText;    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            if (level == 1)
            {
                SceneManager.LoadScene("TimeOut");
            }
            if (level == 2)
            {
                SceneManager.LoadScene("TimeOut2");
            }
            if (level == 3)
            {
                SceneManager.LoadScene("TimeOut3");
            }
        }
        if (currentTime <= 3)
        {
           // Debug.Log("Hello: ");
            countdownText.color = Color.red;
        }
    }
}
