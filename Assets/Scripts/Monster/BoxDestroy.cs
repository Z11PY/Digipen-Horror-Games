using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the triggered object has the tag "Box"
        if (other.gameObject.CompareTag("Monster"))
        {
            // Destroy the box object
            Destroy(gameObject);
        }
    }
}

