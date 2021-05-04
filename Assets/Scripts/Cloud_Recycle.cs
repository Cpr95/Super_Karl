using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Recycle : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1f;
    [SerializeField]
    private bool _randomizeHeight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3.left = Vector3(-1,0,0)
        //Vector3.left (-1) * 1 * _speed(3) = -3
        transform.Translate(Vector3.left * Time.deltaTime * _speed);

        //check the x position of the seaweed if it is smaller then -9 
        if(transform.position.x < -9)
        {
            if(_randomizeHeight)
            {
                float randomYPosition = Random.Range(4f,0f);
                Debug.Log("The random position is: " + randomYPosition);
                //teleport to 39 on the x axis
                transform.position = new Vector3(39,randomYPosition,0);
            }
            else
            {
                transform.position = new Vector3(39,transform.position.y,transform.position.z);
            }
        }
        
    }
}
