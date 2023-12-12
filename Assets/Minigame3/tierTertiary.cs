using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tierTertiary : MonoBehaviour
{
    public AudioSource correctAns;
    public AudioSource wrongAns;
    public ScoreScript scores;
    public animalSpawner spawnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("animalTertiary")){
            correctAns.Play(0);
            scores.scoreValue += 1;
            Destroy(other);
            spawnTrigger.spawnAnimal();
        } else if (!other.gameObject.CompareTag("animalTertiary")){
            wrongAns.Play(0);
            scores.scoreValue -= 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        }

    } //TIER TERTIARY WILL BE USED AS BASIS FOR THE OTHER TIERS, DO NOT DUPLICATE UNTIL THIS TIER IS COMPLETE
}
