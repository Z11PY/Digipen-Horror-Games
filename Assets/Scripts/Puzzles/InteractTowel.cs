using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InteractTowel : MonoBehaviour
{
    public TextMeshProUGUI interactPrompt;
    public bool isTouching;
    public GameObject pipePuzzle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTouching == true && Input.GetKeyDown(KeyCode.E))
        {
            pipePuzzle.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            interactPrompt.enabled = true;
            isTouching = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isTouching = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Puzzle")
        {
            interactPrompt.enabled = false;
        }
    }
}
