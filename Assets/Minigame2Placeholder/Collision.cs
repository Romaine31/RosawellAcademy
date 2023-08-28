using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Collision : MonoBehaviour
    {
        private bool isDragging;
        private Vector3 offset;


        public GameObject chemical3; // The object to be instantiated when collision occurs
        

        void Start()
        {
            offset = Vector3.zero; // Initialize the offset to zero
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

                if (collider != GetComponent<Collider2D>() && collider.CompareTag("chemical3")) 
                {
                    // Instantiate the replacement object at the collision position and rotation
                    Instantiate(chemical3, collider.transform.position, collider.transform.rotation);

                    // Destroy both the dragged object and the cup object
                    Destroy(gameObject);
                    Destroy(collider.gameObject);


                    return true; // Collision detected with a Cup object
                }




         }
            return false; // No collision detected or collided with objects other than Cup
        }
    }