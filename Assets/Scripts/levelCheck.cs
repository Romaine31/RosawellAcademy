using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelCheck : MonoBehaviour
{
    public levelDetails lvlDetail;
    public intValue currentLvl;
    public switchScene sceneSwitcher;
    void Awake()
    {

    }

    private void Start()
    {

    }

    void Update()
    {
        sceneSwitcher.selectedScene = lvlDetail.levelInfo[currentLvl.initialValue].sceneName;
        sceneSwitcher.playerPosition = lvlDetail.levelInfo[currentLvl.initialValue].playerSpawnPosition;
        sceneSwitcher.camMinBoundary = lvlDetail.levelInfo[currentLvl.initialValue].minBoundary;
        sceneSwitcher.camMaxBoundary = lvlDetail.levelInfo[currentLvl.initialValue].maxBoundary;
    }
}
