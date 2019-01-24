using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepMusic : MonoBehaviour
{
    public static keepMusic instance;

	void Start ()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
