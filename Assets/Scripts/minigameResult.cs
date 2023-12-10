using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class minigameResult : MonoBehaviour
{
    public UnityEvent resultScreenExit;
    public ScoreScript pScore;
    public GameObject resultImg;
    public KeyCode interactKey = KeyCode.E;
    public Text scoreText;
    public bool resultsOn;
    void Start()
    {
        resultsOn = false;
        resultImg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (resultsOn == true){
            if(Input.GetKeyDown(interactKey)){
                resultScreenExit.Invoke();
            }
        }
        
    }
    public void showResults(){
        scoreText.text = pScore.scoreValue.ToString();
        resultImg.SetActive(true);
        resultsOn = true;
    }
}
