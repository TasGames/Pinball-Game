using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textUpdater : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public Text hScoreText;
    static protected int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("Highscore", highScore);
        if (Bumper.score > highScore)
        {
            highScore = Bumper.score;
            PlayerPrefs.SetInt("Highscore", highScore);
        }
        hScoreText.text = "High-Score: " + PlayerPrefs.GetInt("Highscore", highScore);
    }

    void Update()
    {
        scoreText.text = "Score: " + Bumper.score;
        livesText.text = "Lives: " + respawnBall.lives;

    }
}
