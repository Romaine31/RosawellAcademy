using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalMilestoneChecker : MonoBehaviour
{
    public floatValue pInfluence;
    public switchScene sceneTrigger;
    // Start is called before the first frame update
    void Start()
    {
        if (pInfluence.initialValue >= 1500f){
            sceneTrigger.selectedScene = "endCutscene";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
