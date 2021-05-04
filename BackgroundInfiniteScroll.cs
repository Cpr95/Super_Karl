using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundInfiniteScroll : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Rigidbody2D rb ;

    private float height;

    private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = boxCollider.size.x;
        rb.velocity = new Vector3(0 ,speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x< -height)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector3 vector = new Vector3(0 , height * 2f);
        transform.position = (Vector3)transform.position + vector;
    }
}
