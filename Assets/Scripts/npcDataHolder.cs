using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDataHolder : MonoBehaviour
{
    public stringValue namesDatabase;
    public intValue npcId;
    public npcDetail npcInfo;
    public int npcCurrentId;
    public string npcName;
    public Sprite npcImage;
    private int nameRand;
    // public AnimatorController npcAnimator;
    void OnEnable()
    {
        npcCurrentId = npcId.initialValue;
        if (npcInfo.npcValues[npcCurrentId].name == null){
        nameRand = Random.Range(0, namesDatabase.stringVal.Count);
        npcInfo.npcValues[npcCurrentId].name = namesDatabase.stringVal[nameRand];
        npcName = npcInfo.npcValues[npcCurrentId].name;
        } else {
            npcName = npcInfo.npcValues[npcCurrentId].name;
        }
        npcSelectSprite();
    }

    public void npcSelectSprite(){
        //npcAnimator = GetComponent<Animator>();
        //npcAnimator.Controller = npcInfo.npcValues[npcCurrentId].animator;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
