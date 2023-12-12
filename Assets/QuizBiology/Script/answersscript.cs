using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answersscript : MonoBehaviour
{
    public quizmanger quizmanager;
    public bool isCorrect = false;
    public ScoreScript scores;
    public AudioSource correctAns;
    public AudioSource wrongAns;
    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct answer");
            quizmanager.correct();
            correctAns.Play(0);
            scores.scoreValue += 1;
        }
        else
        {
            Debug.Log( "Wrong answer");
            quizmanager.correct();
            wrongAns.Play(0);
            scores.scoreValue -= 1;

        }
    }
}

