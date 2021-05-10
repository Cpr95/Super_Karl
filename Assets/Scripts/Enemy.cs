using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Enemy : MonoBehaviour 
{

    public int enemySpeed;

    public int xMoveDir;

    bool moveRight;



// Use this for initialization

void Start () {

        moveRight = true;

}



// Update is called once per frame

void Update () 
{

        if (!moveRight)

        {

            xMoveDir = -1;

        }

        else

        {

            xMoveDir = 1;

        }

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(xMoveDir, 0) * enemySpeed;

    }



    void OnCollisionEnter2D(Collision2D col)

    {

        if (col.gameObject.tag == "Wall")

        {

            if(xMoveDir == 1)

            {

                moveRight = false;

            }

            else

            {

                moveRight = true;

            }

        }

    }

}
