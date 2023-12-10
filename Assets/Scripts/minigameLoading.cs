using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigameLoading : MonoBehaviour
{
    public GameObject loadImg;
    public GameObject sceneCanvas;
    void Start()
    {
        GameObject loadScreen = Instantiate(loadImg, sceneCanvas.transform, worldPositionStays:false) as GameObject;
        Destroy(loadScreen, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
