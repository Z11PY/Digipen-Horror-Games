using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//Rotates the pipes

public class PipeRotate : MonoBehaviour
{
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 0, 90);
        }
    }
}
