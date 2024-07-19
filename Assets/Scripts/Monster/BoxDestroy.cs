using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    private AudioSource audioSource; // Audio source 
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the triggered object has the tag "Box"
        if (other.gameObject.CompareTag("Monster"))
        {
            // Play the audio clip once
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }
            // Destroy the box object
            Destroy(gameObject);
        }
       
    }

}

