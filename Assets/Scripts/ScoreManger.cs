using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManger : MonoBehaviour
{
    public static ScoreManger instance;
    public TextMeshProUGUI text;
    int score=0;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
     public void ChangeScore(int coinValue)
    {
        score += coinValue;
        int scoreLevel = NewBehaviourScript1.instance.getlevelValue();
        text.text =scoreLevel.ToString()+ "/" + score.ToString();
    }
   public int getScore()
    {
        return score;
    }
}
