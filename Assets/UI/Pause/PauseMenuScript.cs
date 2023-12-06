using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenuScript : MonoBehaviour
{

    private bool isPaused = false;
    public GameObject PauseMenuUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the pause state.
            isPaused = !isPaused;
        } 

         if (isPaused)
        {
            Time.timeScale = 0;
            PauseMenuUI.SetActive(true);
        }

        else
        {
            Time.timeScale = 1;
            PauseMenuUI.SetActive(false);
        }
    }

}
