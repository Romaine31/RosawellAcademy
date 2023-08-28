using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class qanda 
{
    public Sprite questionImage; 
    public string Question;  
    public string[] Answer;
    public Text scoretext, timertext;
    public int CorrectAnswer;
}
