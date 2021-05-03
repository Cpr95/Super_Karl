using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Operation : MonoBehaviour
{
    private GameObject player;
    public float xMin; //these variables will clamp the camera into a certain position
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player"); // this searches the game and finds any objects tagged player and connects it with GameObject
    }

    // Update is called once per frame
    void LateUpdate() // Lateupdate is better when using camera systems than using update
    {
        float x = Mathf.Clamp (player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp (player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z); 
    }
}
