using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreLogic : MonoBehaviour
{
    private Text txt;
    private int score = 0;

    private const int scoreIncrement = 10;
    private const int maxScore = 999999999;

	void Start ()
    {
        txt = GetComponent<Text>();
	}
	
	void Update ()
    {
        PrintScore();
	}

    void PrintScore()
    {
        txt.text = "Score: " + score;
    }

    public void AddToScore()
    {
        score += scoreIncrement;

        if(score >= maxScore)
        {
            score = maxScore;
        }

        PrintScore();
    }
}
