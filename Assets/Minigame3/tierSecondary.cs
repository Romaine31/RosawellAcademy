using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tierSecondary : MonoBehaviour
{
    public animalManager g3Manager;
    public animalSpawner spawnTrigger;
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("animalSecondary")){
            g3Manager.score += 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        } else if (!other.gameObject.CompareTag("animalSecondary")){
            g3Manager.score -= 1;
            Destroy(other.gameObject);
            spawnTrigger.spawnAnimal();
        }

    }
}
