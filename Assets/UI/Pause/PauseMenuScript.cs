using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            pauseMenuUI.SetActive(true);
        }

        else
        {
            Time.timeScale = 1;
            pauseMenuUI.SetActive(false);
        }
    }

     public void OnResumeButtonClick()
    {
        // Unpause the game.
        isPaused = false;
    }

    public void OnMenuButtonClick()
    {
        // Load the main menu scene.
        SceneManager.LoadScene("MainMenu");
    }
}
