using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnItem : MonoBehaviour
{
    public GameObject food;
    public List<foodType> foodImg; // Index 0 will be fruits, and index 1 will be vegetables
    public int tagIndex;
    public GameObject foodSpawned;
    public Vector2 spawnLoc;
    private string[] foodTags = {"fruit", "vegetable"};
    public SpriteRenderer spriteRenderer;
    public GameObject currentFood;
[System.Serializable]
    public class foodType{
        public List<Sprite> foodSprite;
    }

    void Start()
    {
        spawnFruit();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void spawnFruit(){
        tagIndex = Random.Range(0,2);
        currentFood = Instantiate(food, spawnLoc, Quaternion.identity);
        currentFood.tag = foodTags[tagIndex];
        selectSprite();
    }

    public void selectSprite(){
        spriteRenderer = currentFood.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = foodImg[tagIndex].foodSprite[Random.Range(0, foodImg[tagIndex].foodSprite.Count)];
    } //0 is fruit, 1 is vegetable
}
