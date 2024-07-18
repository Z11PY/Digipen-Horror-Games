using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieToStairs : MonoBehaviour
{
    // add this to the stairs for it to kill player
    void start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("End Game");
            Destroy(collision.gameObject);

        }

    }
}
