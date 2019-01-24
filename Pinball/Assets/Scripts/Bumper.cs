using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    static public int score;
    [SerializeField] protected AudioClip bump;
    [SerializeField] protected int value;

    void Start()
    {
        score = 0;
        GetComponent<AudioSource>().clip = bump;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        score += value;
        GetComponent<AudioSource>().Play();
    }
}

