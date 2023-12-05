using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalSpawner : MonoBehaviour
{
    public GameObject animalPrefab;
    // Element 0 will be tertiary and Element 3 will be the producers
    public List<animalTypes> animalSprites;
    public Vector2 spawnArea;
    public int tagIndex;
    public int spriteIndex;
    public GameObject animalClone;
    public SpriteRenderer spriteRenderer;
    private string[] animalTags = {"animalTertiary", "animalSecondary", "animalPrimary", "animalProducer"};
    [System.Serializable]
    public class animalTypes{
        public List<Sprite> animalImgs;
    }
    public void spawnAnimal(){
        tagIndex = Random.Range(0,4);
        spawnArea = new Vector2(Random.Range(-8.5f,-3f),Random.Range(-3.5f,4f));
        animalClone = Instantiate(animalPrefab,spawnArea,Quaternion.identity);
        animalClone.tag = animalTags[tagIndex];
        selectSprite();
    }

    public void selectSprite(){
        spriteRenderer = animalClone.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = animalSprites[tagIndex].animalImgs[Random.Range(0, animalSprites[tagIndex].animalImgs.Count)];
    }

}
