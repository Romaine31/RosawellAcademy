using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{


    public void PlayGame(){
        SceneManager.LoadScene("homeScene");
    }
    public void ExitGame(){
        Debug.Log("Exit");
        Application.Quit();
    }
    public void LoadGame(){
        SceneManager.LoadScene("homeScene");
        Debug.Log("LOADING");
    }
    public void Settings(){
        Debug.Log("Settigs");
    }
}
