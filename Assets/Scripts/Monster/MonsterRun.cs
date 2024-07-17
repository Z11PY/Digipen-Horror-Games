using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterRun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 3.5f; // Speed at which the sprite moves

    void Update()
    {
        // Move the sprite forward based on its current direction
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}

