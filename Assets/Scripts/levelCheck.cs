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
        sceneSwitcher = GetComponent<switchScene>();
    }

    private void Start()
    {

    }

    void Update()
    {
        sceneSwitcher.selectedScene = lvlDetail.levelInfo[currentLvl.initialValue].sceneName;
        //sceneSwitcher
    }
}
