using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tierProducer : MonoBehaviour
{
    public ScoreScript scores;
    public animalSpawner spawnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("animalProducer")){
            scores.scoreValue += 1;
            Destroy(other);
            spawnTrigger.spawnAnimal();
        } else if (!other.gameObject.CompareTag("animalProducer")){
            scores.scoreValue -= 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        }

    }
}
