using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{

    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;

    
    
    // Update is called once per frame
    void Update()
    {
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore); 
    } 
    void OnTriggerEnter2D (Collider2D trig)
    { 
        if (trig.gameObject.name == "Coin")
        {
            playerScore += 100;
            Destroy (trig.gameObject);
        }
        
    }
    
}
