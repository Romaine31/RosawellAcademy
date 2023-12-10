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
    public List<GameObject> itemList;
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
        updateItemList();
        // replace this later
        // if (itemCheck.storeItem[0] == true){
        //     item1.text = "Anatomy Model";
        // }
        // if (itemCheck.storeItem[1] == true){
        //     item1.text = "Whiteboard";
        // }
        // if (itemCheck.storeItem[2] == true){
        //     item1.text = "Beakers";
        // }
    }

    public void updateItemList(){
        for (int i = 0; i < itemList.Count; i++){ //replace itemList with itemCheck
            if (itemCheck.storeItem[i] == true){
                itemList[i].SetActive(true);
            } else if (itemCheck.storeItem[i] == false){
                itemList[i].SetActive(false);
            }
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
