using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUpdater : MonoBehaviour
{
    [SerializeField] protected Text scoreText;
    [SerializeField] protected Text livesText;
    [SerializeField] protected Text hScoreText;
    static protected int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore", highScore);
        if (Bumper.score > highScore)
        {
            highScore = Bumper.score;
            PlayerPrefs.SetInt("Highscore", highScore);
        }

        if (hScoreText != null)
            hScoreText.text = "High-Score: " + PlayerPrefs.GetInt("Highscore", highScore);
    }

    void Update()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + Bumper.score;
        
        if (livesText != null)
            livesText.text = "Lives: " + respawnBall.lives;
    }
}
