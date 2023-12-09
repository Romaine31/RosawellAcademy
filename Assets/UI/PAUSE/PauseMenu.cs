using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public UnityEvent quitEvent;

    [SerializeField] private GameObject PauseMenuUI;
    public Text item1, item2, item3;
    public boolList itemCheck;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (GameIsPaused) {
                Resume();
            }
            else{
                Pause();
            }
        }
        // replace this later
        if (itemCheck.storeItem[0] == true){
            item1.text = "Anatomy Model";
        }
        if (itemCheck.storeItem[1] == true){
            item1.text = "Whiteboard";
        }
        if (itemCheck.storeItem[2] == true){
            item1.text = "Beakers";
        }

    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit(){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        quitEvent.Invoke();
    }
}
