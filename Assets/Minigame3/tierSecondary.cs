using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tierSecondary : MonoBehaviour
{
    public ScoreScript scores;
    public animalSpawner spawnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("animalSecondary")){
            scores.scoreValue += 1;
            Destroy(other);
            spawnTrigger.spawnAnimal();
        } else if (!other.gameObject.CompareTag("animalSecondary")){
            scores.scoreValue -= 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        }

    }
}
