using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnBall : MonoBehaviour
{
    protected Rigidbody2D ballR;
    public GameObject ball;
    static public int lives;

    void Start()
    {
        ballR = ball.GetComponent<Rigidbody2D>();
        lives = 2;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "BallTag" && lives > 0)
        {
            ball.transform.position = new Vector3(2.45f, -0.5f, 0);
            ballR.velocity = new Vector3(0, 0, 0);
            lives = lives - 1;
        }
        else if (collider.tag == "BallTag" && lives == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
