using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcSpawner : MonoBehaviour
{
    public GameObject npcPrefab;
    public intValue npcID;
    
    // Start is called before the first frame update
    void Awake(){
        npcID.initialValue = 0;
    }
    void Start()
    {
            for (int x = 0; x< 15; x++){
                Instantiate(npcPrefab, transform.position, Quaternion.identity);
                Debug.Log("npc count: "+x);
                npcID.initialValue++;
            }
            
    }

    // Update is called once per frame
    void Update()
    {

    }
}
