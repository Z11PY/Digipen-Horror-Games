using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterForward : MonoBehaviour
{
    public float speed = 3.7f;

    void Update()
    {
        // Calculate the new position
        Vector3 newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime;

        // Apply the new position
        transform.position = newPosition;
    }
}

