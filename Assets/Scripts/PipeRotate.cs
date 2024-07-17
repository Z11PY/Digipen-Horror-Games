using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine;

//Rotates the pipes

public class PipeRotate : MonoBehaviour
{
    public float solved;
    public Quaternion pipeRotation;
    public GameObject pipe;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, 90);
            Debug.Log("Clicked");
            pipeRotation = pipe.transform.rotation;
        }
    }

    private void FixedUpdate()
    {
        //if(pipeRotation = )
        {

        }
    }

    void PuzzleComplete()
    {

    }
}
