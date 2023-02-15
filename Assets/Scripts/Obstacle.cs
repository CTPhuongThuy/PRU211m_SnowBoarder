using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<GameSession>().SaveHighestScore();
            Invoke("ReloadScene", 0.5f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //GetComponent<AudioSource>().Play();
            FindObjectOfType<GameSession>().SaveHighestScore();
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
