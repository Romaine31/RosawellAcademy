using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int playerSpeed = 8;
    public Vector2 lastMotionVector;
    private Rigidbody2D characterBody;
    private Vector2 velocity;
    private Vector2 movementInput;
    public vectorValue startingPos;
    public Animator anim;

    void Start()
    {
        velocity = new Vector2(playerSpeed, playerSpeed);   //initializes velocity value
        characterBody = GetComponent<Rigidbody2D>();    // gets character body
        transform.position = startingPos.initialValue; // sets player position in the world
    }

    void Update()
    {
        Animate();
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movementInput = new Vector2 (horizontal, vertical); // moves player

        if (horizontal != 0 || vertical !=0)
        {
            lastMotionVector =  new Vector2(horizontal, vertical);
        }   // stores the last location the player was heading at, this is where the player is facing
        Animate();
    }

    void FixedUpdate()
    {
        if (dialogueManager.isActive == true)
        return;

        Vector2 delta = movementInput * velocity * Time.deltaTime;
        Vector2 newPosition = characterBody.position + delta;
        characterBody.MovePosition(newPosition);
    }   // i forgot what this actually does, maybe someone can figure it out -Romaine (REMOVE THIS COMMENT LATER LOL)

    void Animate()
    {
        anim.SetFloat("AnimMoveX",movementInput.x );
        anim.SetFloat("AnimMoveY",movementInput.y );
        anim.SetFloat("AnimMoveMagnitude",movementInput.magnitude );
        anim.SetFloat("AnimLastMoveX",lastMotionVector.x );
        anim.SetFloat("AnimLastMoveY",lastMotionVector.y );
    }
}
