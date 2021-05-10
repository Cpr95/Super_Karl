using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour
{
private float timeLeft = 120;
public int playerScore = 0;
public GameObject timeLeftUI;
public GameObject playerScoreUI;   

    void Start() {
        DataManagement.datamanagement.LoadData();
    }
    
    // Update is called once per frame
    void Update()
    { 
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore); 
        if (timeLeft <0.1f) 
        {
            SceneManager.LoadScene ("0");
        }
    } 
    void OnTriggerEnter2D (Collider2D trig)
    { 
        if (trig.gameObject.name == "EndLevel")
        {
            CountScore (); 
        }
        if (trig.gameObject.name == "Coin")
        {
            playerScore += 100;
            Destroy (trig.gameObject);
        }
        
    }
    void CountScore ()
    {
        Debug.Log ("Data says high score is currently" + DataManagement.datamanagement.highScore);
        playerScore = playerScore + (int)(timeLeft * 10);
        DataManagement.datamanagement.highScore = playerScore + (int)(timeLeft * 100);
        DataManagement.datamanagement.SaveData ();
        Debug.Log ("Now that we have adde the score toDataManagement, Data says high score is currently" + DataManagement.datamanagement.highScore);
    }
    
}
