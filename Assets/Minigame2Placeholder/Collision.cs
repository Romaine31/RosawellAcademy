using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Collision : MonoBehaviour
    {
        private bool isDragging;
        private Vector3 offset;
        public problemManager probManager;
        public ScoreScript scores;
        public AudioSource correctAns;
        public AudioSource wrongAns;

        public GameObject chemical3; // The object to be instantiated when collision occurs
        

        void Start()
        {
            offset = Vector3.zero; // Initialize the offset to zero
        }
        void OnEnable() {
            probManager = GameObject.FindWithTag("chemGameManager").GetComponent<problemManager>();
            scores = GameObject.FindWithTag("scoreText").GetComponent<ScoreScript>();
            correctAns = GameObject.FindWithTag("cAudio").GetComponent<AudioSource>();
            wrongAns = GameObject.FindWithTag("wAudio").GetComponent<AudioSource>();
        }

        void Update()
        {
            if (isDragging)
            {
                Vector2 newPosition = offset + Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = newPosition;
            }

            if (!isDragging && !CheckCollision()) // Check if not dragging and no collision
            {
                
            }
        }

        public void OnMouseDown()
        {
            isDragging = true;
            offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition); // Update the offset when clicked
        }

        public void OnMouseUp()
        {
            isDragging = false;
        }

        private bool CheckCollision()
        {
            Collider2D[] colliders = Physics2D.OverlapBoxAll(transform.position, transform.localScale, 0f);
            foreach (Collider2D collider in colliders)
         {
            // first layer for the cup

                if (collider != GetComponent<Collider2D>() && collider.CompareTag("chemicalGoal")) 
                {
                    

                    // Destroy both the dragged object and the cup object
                    for (int i = 0; i < probManager.cloneList.Count; i++){
                    Destroy(probManager.cloneList[i]);
                    }
                    correctAns.Play(0);
                    scores.scoreValue += 1;
                    probManager.cloneList = new List<GameObject>();
                    return true;
                } else if (collider != GetComponent<Collider2D>() && collider.CompareTag("notChemical")){
                    for (int i = 0; i < probManager.cloneList.Count; i++){
                    Destroy(probManager.cloneList[i]);
                    }
                    wrongAns.Play(0);
                    probManager.cloneList = new List<GameObject>();
                    if (scores.scoreValue > 0){
                        scores.scoreValue -= 1;
                    }
                    return true;
                }




         }
            return false; // No collision detected or collided with objects other than Cup
        }
    }