using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieToStairs : MonoBehaviour
{

    void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Game");
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("PlayerF"))
        {

            // Load the "Jump Scare" scene
            SceneManager.LoadScene("Jump Scare");
        }
    }
}
 
