using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int currentScore;
    public Text scoreText;
   
   

    public void PlayerScore(int scoreValue)
    {
        currentScore += scoreValue;
        scoreText.text = "Score: " + currentScore;
        WinPlayer();
    }

  // win player //  
    void WinPlayer()
    { 
        if(currentScore==11)
        {
        SceneManager.LoadScene("WinScene");
        }
    }
}
