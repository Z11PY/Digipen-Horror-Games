using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [HideInInspector] public float centerX, centerY, left, top, right, bottom;
    BoxCollider2D boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        centerX = transform.position.x;
        centerY = transform.position.y;
        left = transform.position.x - (boxCollider.bounds.size.x / 2.0f);
        top = transform.position.y + (boxCollider.bounds.size.y / 2.0f);
        right = transform.position.x + (boxCollider.bounds.size.x / 2.0f);
        bottom = transform.position.y - (boxCollider.bounds.size.y / 2.0f);
    }
}
