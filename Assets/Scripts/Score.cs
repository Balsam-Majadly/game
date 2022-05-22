using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public float speed;
    public Vector3 Target;
    public int enemyValue;
    public  int scoreLevel=2;

    public int coinValue;
    /*
    void Start()
    {
        
    }

     void Update()
    {
        timer += Time.deltaTime;
        if (timer>= newtarget)
        {
            newTarget();
            timer = 0;
        }
        
    }

    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myz = gameObject.transform.position.z;
        float myy = gameObject.transform.position.y;
        float xPos = myX + Random.Range(myX - 2, myX + 2);
        float zPos = myX + Random.Range(myz -2, myz + 2);
        float yPos = myy + Random.Range(myy - 2, myy + 2);
        Target = new Vector3(xPos, yPos, zPos);
        transform.Translate(Target);
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
           int playValue= NewBehaviourScript.instance.getPlayerValue();
            if (playValue == scoreLevel)
            {
                SceneManager.LoadScene("WinScene");
            }
            else if (playValue < enemyValue)
            {
                Debug.Log("player: " + playValue);
                Debug.Log("enemy: " + enemyValue);
                SceneManager.LoadScene("LoseScene");
            }
            ScoreManger.instance.ChangeScore(coinValue);
            
        }
    }
}
