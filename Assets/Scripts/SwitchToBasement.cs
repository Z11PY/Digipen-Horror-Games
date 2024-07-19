using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchToBasement : MonoBehaviour
{
    public float delay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayToSwitchScene(delay));
    }

    private IEnumerator DelayToSwitchScene(float delay) { 
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        //Load the "Basement" scene
        SceneManager.LoadScene("Basement");


    }
}
