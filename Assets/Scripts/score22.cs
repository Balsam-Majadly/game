using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;
public class score22 : MonoBehaviour
{
    public float timer;
    public int newtarget;
    public float speed;
    public Vector3 Target;
    public int enemyValue;
   // public int scoreLevel = 2;
    /// <summary>
    ///
    /// </summary>
    public float timeForNewPath;
    bool inCoRoutine;
    public Rigidbody rb;
    public float movementSpeed = 10f;
    public float moveSpeed = 0.5f;
    public float rotateSpeed = 0.5f;

    public int coinValue;



    Vector3 getNewRandomPosition()
    {
        float X = Random.Range(-1, 0);
        float Y = Random.Range(-1, 1);
        float Z = Random.Range(-1, 0);
        Vector3 pos = new Vector3(X, 0, Z);
        return pos;
    }/*
    IEnumerator DoSomething()
    {
        inCoRoutine = true;
        yield return new WaitForSeconds(timeForNewPath);
        GetNewPath();
        inCoRoutine = false;
    }
    void GetNewPath()
    {

        //transform.position =transform.position+ getNewRandomPosition();
        //transform.Translate(getNewRandomPosition());
        //rb.MovePosition(transform.position + (getNewRandomPosition() * movementSpeed * Time.deltaTime));
        Vector3 pos = getNewRandomPosition();
        transform.position = pos * Time.deltaTime;
    }*/
    /*
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

    void Update()
    {

        // transform.Translate(getNewRandomPosition() * moveSpeed * Time.deltaTime, Space.World);

        //transform.Rotate(0, 0, 1f * rotateSpeed * Time.deltaTime);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            int playValue = NewBehaviourScript1.instance.getPlayerValue();
            int scoreLevel = NewBehaviourScript1.instance.getlevelValue();
            int Level = NewBehaviourScript1.instance.getlevel();
            ScoreManger.instance.ChangeScore(coinValue);
            int x = ScoreManger.instance.getScore();

            if (playValue < enemyValue)
            {
                Debug.Log("player: " + playValue);
                Debug.Log("enemy: " + enemyValue);
                if (Level == 1)
                {
                    SceneManager.LoadScene("LoseScene");
                }
                if (Level == 2)
                {
                    SceneManager.LoadScene("LoseScene2");
                }
                if (Level == 3)
                {
                    SceneManager.LoadScene("LoseScene3");
                }
            }
            if (x >= scoreLevel)
            {
                if (Level == 1)
                {
                    SceneManager.LoadScene("WinScene");
                }
                if (Level == 2)
                {
                    SceneManager.LoadScene("WinScene2");
                }
                if (Level == 3)
                {
                    SceneManager.LoadScene("WinScene3");
                }
            }
            // ScoreManger.instance.ChangeScore(coinValue);

        }
    }
}
