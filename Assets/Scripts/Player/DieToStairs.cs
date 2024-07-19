using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieToStairs : MonoBehaviour
{
    public float delay = 3f;

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
            
            StartCoroutine(DelayToSwitchScene(delay));
        }
    }

    private IEnumerator DelayToSwitchScene(float delay)
    {
        // Load the "Jump Scare" scene
        SceneManager.LoadScene("Jump Scare");
       
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        //Load the "Basement" scene
        SceneManager.LoadScene("Basement");
        

    }
}