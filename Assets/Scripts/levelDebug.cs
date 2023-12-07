using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelDebug : MonoBehaviour
{
    public intValue playerLv;
    public void changeToLv1 (){
        playerLv.initialValue = 0;
        SceneManager.LoadScene("School1");
    }
    public void changeToLv2 (){
        playerLv.initialValue = 1;
        SceneManager.LoadScene("School2");
    }
    public void changeToLv3 (){
        playerLv.initialValue = 2;
        SceneManager.LoadScene("School3");
    }
}
