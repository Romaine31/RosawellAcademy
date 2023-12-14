using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsOpen : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    // Start is called before the first frame update

    public void switchToSetting(){
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    public void switchToPause(){
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            switchToPause();
        }
    }
}
