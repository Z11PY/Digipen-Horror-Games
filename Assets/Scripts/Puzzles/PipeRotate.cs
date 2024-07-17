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
    public GameObject puzzle;
    public GameObject pipe;
    public GameObject LockedDoor;

        void Update()
        {
            if (solved == 1)
            {
                LockedDoor.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            LockedDoor.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            puzzle.SetActive(false);
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

    public void RotatePipe()
    {
        pipe.transform.Rotate(0, 0, 90);
        Debug.Log("Rotate");
        pipeRotated = true;
        solved += 1;
    }

}
