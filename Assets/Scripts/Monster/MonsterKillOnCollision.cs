using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterKillOnCollision : MonoBehaviour
{
    void start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Game");
            // Destroy the player GameObject
            Destroy(collision.gameObject);
            
        }

    }

}

