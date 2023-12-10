using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public string tagString;
    public ScoreScript scores;
    public spawnItem spawner;
    
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag(tagString)){
            scores.scoreValue += 1;
            Destroy(other.gameObject);
            spawner.spawnFruit();
        } else if (!other.gameObject.CompareTag(tagString)){
            scores.scoreValue -= 1;
            Destroy(other.gameObject);
            spawner.spawnFruit();
        }
    }

    
}
