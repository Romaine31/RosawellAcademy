using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcSpawner : MonoBehaviour
{
    public GameObject npcPrefab;
    public int spawnAmount;
    public intValue npcID;
    
    // Start is called before the first frame update
    void Awake(){
        npcID.initialValue = 0;
    }
    void Start()
    {
        var newRotation = new Quaternion(0,0,0,0);
            for (int x = 0; x < spawnAmount; x++){
                Instantiate(npcPrefab, transform.position, newRotation);
                Debug.Log("npc count: "+x);
                npcID.initialValue++;
            }
            
    }

    // Update is called once per frame
    void Update()
    {

    }
}
