using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
