 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int enemySpeed;
    public int MoveDirection;
    public bool moveRight = true;

 // Use this for initialization
 void Start () {
        moveRight = true;
 }
 
 // Update is called once per frame
 void Update () {
        if (!moveRight)
        {
            MoveDirection = 1;
        }
        else
        {
            MoveDirection = -1;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(MoveDirection, 0) * enemySpeed;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            if(MoveDirection == -1)
            {
                Flip ();
            }
            else
            {
                Flip ();
            }
        }
    }

    void Flip () 
    {
        moveRight = !moveRight; // the exclamation mark means not true - facing right does not equal facing right
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale; 
        // if player is facing right and does not want to face right any more, local scale will change the scale to negative
    }
}
