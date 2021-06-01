using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class UIAppear : MonoBehaviour
 {
     [SerializeField] private Image customimage;
 
     void OnTriggerEnter2D (Collider2D trig)
    { 
        if (trig.gameObject.tag == "Player")
        {
            customimage.enabled = true;
        }
    }
 
     void OnTriggerExit2D (Collider2D trig)
    { 
        if (trig.gameObject.tag == "Player")
        {
            customimage.enabled = false;
        }
     }
 }