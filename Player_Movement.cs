using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int playerSpeed = 10; // This is for the characters speed
    public bool facingRight = true; // true or false, is the player facing left or right ?
    public int playerJump = 1250;
    private float moveX;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove (); // so that the player is able to move every single frame 
    }

    void PlayerMove() 
    {

        // Player Controls 
        moveX = Input.GetAxis("Horizontal"); //the player can move on the horizontal axis

        if (Input.GetButtonDown ("Jump") == true) //if user presses jump button player will jump
        {
            Jump();
        }

        // Player Animations

        // Player Direction
        if (moveX < 0.0f && facingRight == false)  // if player is not facing right, the player will now face to the left
        {
            FlipPlayer ();
        }
        else if (moveX > 0.0f && facingRight == true)
        {
            FlipPlayer ();
        }

        // Physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        // this will make the player move left and right
    }
    
    void Jump()
    {
        //Player Jump Code
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJump); // this will add force upwards associated to the player 
        isGrounded = false;
   }

    void FlipPlayer() 
    {
        facingRight = !facingRight; // the exclamation mark means not true - facing right does not equal facing right
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale; 
        // if player is facing right and does not want to face right any more, local scale will change the scale to negative
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log ("Player has collided with " + col.collider.name);
        if (col.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }
}
