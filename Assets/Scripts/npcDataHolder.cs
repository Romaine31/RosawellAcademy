using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDataHolder : MonoBehaviour
{
    // public stringValue namesDatabase;
    public intValue npcId;
    public npcDetail npcInfo;
    public int npcCurrentId;
    public string npcName;
    private int nameRand;
    public Animator npcAnimator;
    void OnEnable()
    {
        npcCurrentId = npcId.initialValue;
        npcName  = npcInfo.npcValues[npcCurrentId].name;
        // if (npcInfo.npcValues[npcCurrentId].name == null){
        // nameRand = Random.Range(0, namesDatabase.stringVal.Count);
        // npcInfo.npcValues[npcCurrentId].name = namesDatabase.stringVal[nameRand];
        // npcName = npcInfo.npcValues[npcCurrentId].name;
        // } else {
        //     npcName = npcInfo.npcValues[npcCurrentId].name;
        // }
        // npcSelectSprite();
        npcAnimator = GetComponent<Animator>();
        npcAnimator.runtimeAnimatorController = npcInfo.npcValues[npcCurrentId].animController;
    }

    // public void npcSelectSprite(){
        
    // }
    // Update is called once per frame
    void Update()
    {
        
    }
}
