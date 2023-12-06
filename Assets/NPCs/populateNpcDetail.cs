using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populateNpcDetail : MonoBehaviour
{
    public npcDetail npcInfo;
    public controllerStorage animStorage;
    public stringValue namesStorage;
    public boolValue npcsSpawned;
    void Start()
    {
        if (npcsSpawned.initialValue == false){
            for (int x = 0; x < npcInfo.npcValues.Length; x++) {
                npcInfo.npcValues[x].name = namesStorage.stringVal[Random.Range(0, namesStorage.stringVal.Count)];
                npcInfo.npcValues[x].animController = animStorage.charController[Random.Range(0, animStorage.charController.Count)];
                npcInfo.npcValues[x].multiplier = 1;
                npcInfo.npcValues[x].admiration = 1;
            }
            npcsSpawned.initialValue = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
