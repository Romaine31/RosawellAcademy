using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    int finalscore;
    public intValue playerMoney;
    public floatValue playerInfluence;
    float scoreDivided;
    
    // Start is called before the first frame update
    void Start()
    {
       score = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

    }

    void OnDestroy()
    {
        scoreDivided = scoreValue * 0.2f;
        playerMoney.initialValue += scoreValue;
        playerInfluence.initialValue += scoreDivided;
    }
}
