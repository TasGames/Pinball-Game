using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    static public int score;
    public AudioClip bump;

    void Start()
    {
        score = 0;
        GetComponent<AudioSource>().clip = bump;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        score += 1000;
        GetComponent<AudioSource>().Play();
    }
}

