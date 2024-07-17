using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

//Rotates the pipes

public class PipeRotate : MonoBehaviour
{
    public float solved;
    public bool pipeRotated;
    public GameObject LockedDoor;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && pipeRotated == false)
        {
            StartCoroutine(OneTurn());
        }
        if (Input.GetMouseButtonDown(0) && pipeRotated == true)
        {
            StartCoroutine (TwoTurn());
        }
    }

    void Update()
    {
        if(solved == 1)
        {
            SceneManager.LoadScene("2ndFloor");
            LockedDoor.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    IEnumerator OneTurn()
    {
        yield return null;
        transform.Rotate(0, 0, 90);
        Debug.Log("Rotate");
        pipeRotated = true;
        solved += 1;
    }

    IEnumerator TwoTurn()
    {
        yield return null;
        transform.Rotate(0, 0, 90);
        pipeRotated = false;
        solved -= 1;
    }
}
