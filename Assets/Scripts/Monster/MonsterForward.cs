using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterForward : MonoBehaviour
{
  
    public float baseWalk = 0.1f; //base walk when not seeing the player 
    public float initialSpeed = 1f; // Initial speed when the monster starts chasing
    public float chaseSpeed = 3.5f; // Speed at which the monster chases the player after 1 second
    private Transform player; // Reference to the player's transform
    private bool isChasing = false; // check if the monster is chasing the player
    private bool isSpeedIncreased = false; // check if the speed has been increased

    void Update()
    {
        if (isChasing)
        {
            // Move the monster upwards only
            float currentSpeed = isSpeedIncreased ? chaseSpeed : initialSpeed;
            transform.Translate(Vector2.down * currentSpeed * Time.deltaTime);
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
            isSpeedIncreased = false; // Reset the speed increase flag
            StartCoroutine(IncreaseSpeedAfterDelay(1f)); // Start the delay to increase speed after 1 second
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
            StopAllCoroutines(); // Stop all delays to prevent speed increase if the player leaves the trigger
        }
    }

    private IEnumerator IncreaseSpeedAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        isSpeedIncreased = true;
    }
}

