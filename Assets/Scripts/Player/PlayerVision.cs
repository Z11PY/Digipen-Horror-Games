using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            // Make the collider visible
            SetColliderVisibility(other, true);
        }
        else if(other.gameObject.tag == "Door")
        {
            SetColliderVisibility(other, true);
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag != "Wall")
        {
            // Make the collider invisible
            SetColliderVisibility(other, false);
        }
        else if (other.gameObject.tag != "Door")
        {
            SetColliderVisibility(other, false);
        }
    }

    private void SetColliderVisibility(Collider2D collider, bool isVisible)
    {
        
        // Set the visibility of the collider's game object
        if (collider != null)
        {
            SpriteRenderer spriteRenderer = collider.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.enabled = isVisible;
            }
        }
    }
}
