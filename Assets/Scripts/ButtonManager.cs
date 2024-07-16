using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// changes scene to 2ndfloor 
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene("2ndFloor");
    }
    /// <summary>
    /// goes to the main menu
    /// </summary>
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Tips");
    }
}
