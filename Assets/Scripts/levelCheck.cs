using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCheck : MonoBehaviour
{
    public levelDetails lvlDetail;
    public intValue currentLvl;
    public switchScene sceneSwitcher;
    public string thisSceneName;
    void Awake()
    {

    }

    private void Start()
    {
        thisSceneName = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        if (thisSceneName == "mapScreen"){
        sceneSwitcher.selectedScene = lvlDetail.levelInfo[currentLvl.initialValue].sceneName;
        sceneSwitcher.playerPosition = lvlDetail.levelInfo[currentLvl.initialValue].playerSpawnPosition;
        sceneSwitcher.camMinBoundary = lvlDetail.levelInfo[currentLvl.initialValue].minBoundary;
        sceneSwitcher.camMaxBoundary = lvlDetail.levelInfo[currentLvl.initialValue].maxBoundary;
        } else {sceneSwitcher.selectedScene = lvlDetail.levelInfo[currentLvl.initialValue].sceneName;}
    }
}
