using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScene : MonoBehaviour
{
    public string selectedScene;
    public Vector2 playerPosition;
    public vectorValue playerStoredPosition;
    public Vector2 camMinBoundary;
    public Vector2 camMaxBoundary;
    public cameraVectors cameraStoredPositions;
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float changeDelay;

    private void Awake()
    {
        if(fadeInPanel != null) // calls fade in panel
        {
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }

    public void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player") && !player.isTrigger) //this checks if the player enters the switchScene collider and switches the scene
        {
            changeScene();
        }
    }

    public IEnumerator fadeCo() //this enumarator controls the fade in and fade out
    {
        if (fadeOutPanel != null)
        {
        Instantiate (fadeOutPanel, Vector3.zero, Quaternion.identity);
        }
        yield return new WaitForSeconds(changeDelay);
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(selectedScene);
        while(!asyncOperation.isDone)
        {
            yield return null;
        }
    }

    public void changeScene()
    {
            playerStoredPosition.initialValue = playerPosition; //this stores the player's last position before they leave the scene
            cameraStoredPositions.initialMinValue = camMinBoundary;
            cameraStoredPositions.initialMaxValue = camMaxBoundary; //stores the camera boundaries of the previous scene
            StartCoroutine(fadeCo());
    }
}
