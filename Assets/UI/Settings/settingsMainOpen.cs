using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsMainOpen : MonoBehaviour
{
    public GameObject settingsMenu;

    public void openSettings(){
        settingsMenu.SetActive(true);
    }
    public void closeSettings(){
        settingsMenu.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
