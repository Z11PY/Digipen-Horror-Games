    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    public float chaseSpeed = 3.5f; // Speed at which the monster chases the player
    private Transform player; // Reference to the player's transform
    private bool isChasing = false; // Flag to check if the monster is chasing the player

    void Update()
    {
        if (isChasing && player != null)
        {
            chaseSpeed = 3.5f;
            // Move the monster towards the player
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the GameObject we collided with has the tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            // Start chasing the player
            player = other.transform;
            isChasing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the GameObject we stopped colliding with has the tag "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            // Stop chasing the player
            isChasing = false;
            player = null;
        }
    }
}

