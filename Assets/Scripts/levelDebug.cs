using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelDebug : MonoBehaviour
{
    public intValue playerLv;
    public void changeToLv1 (){
        playerLv.initialValue = 0;
        SceneManager.LoadScene("mapScreen");
        
    }
    public void changeToLv2 (){
        playerLv.initialValue = 1;
        SceneManager.LoadScene("mapScreen");
    }
    public void changeToLv3 (){
        playerLv.initialValue = 2;
        SceneManager.LoadScene("mapScreen");
    }
    public void changeToLv4 (){
        playerLv.initialValue = 3;
        SceneManager.LoadScene("mapScreen");
    }
}
