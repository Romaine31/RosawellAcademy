using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDataHolder : MonoBehaviour
{
    public intValue npcId;
    public npcDetail npcInfo;
    public int npcCurrentId;
    public string npcName;
    public Sprite npcImage;
    void OnEnable()
    {
        //npcCurrentId = npcId.initialValue;
        //npcName = npcInfo.name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
