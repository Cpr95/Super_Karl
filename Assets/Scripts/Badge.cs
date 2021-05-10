using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Badge : MonoBehaviour
{
    int BadgeValue = 100;

    void OnTriggerEnter2D() 
    {
        print(BadgeValue);
        Destroy(gameObject);
    }
}
