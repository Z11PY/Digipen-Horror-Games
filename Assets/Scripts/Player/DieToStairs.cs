using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieToStairs : MonoBehaviour
{
    public bool hasFlashLight = false;
    float delay = 3f;
    // add this to the stairs for it to kill player
    void start()
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
            SceneManager.LoadScene("Jump Scare");
            StartCoroutine(DelayToSwitchScene(delay));
        }

    }
    private IEnumerator DelayToSwitchScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("");
    }
}
