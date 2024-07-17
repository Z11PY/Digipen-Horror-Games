using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Interact : MonoBehaviour
{
    public TextMeshProUGUI interactPrompt;
    GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            interactPrompt.enabled = true;
        }
        if (collision.gameObject.tag == "Door")
        {
            interactPrompt.enabled = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puzzle" && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Pipe puzzle");
        }
        if (collision.gameObject.tag == "Door" && Input.GetKeyDown(KeyCode.E))
        {
            //collision.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, 0, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            interactPrompt.enabled = false;
        }
    }
}
