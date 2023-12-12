using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tierProducer : MonoBehaviour
{
    public AudioSource correctAns;
    public AudioSource wrongAns;
    public ScoreScript scores;
    public animalSpawner spawnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("animalProducer")){
            correctAns.Play(0);
            scores.scoreValue += 1;
            Destroy(other);
            spawnTrigger.spawnAnimal();
        } else if (!other.gameObject.CompareTag("animalProducer")){
            wrongAns.Play(0);
            scores.scoreValue -= 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        }

    }
}
