using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class giveplayerflashlight : MonoBehaviour
{
    public Sprite playeWF;
    public GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.tag = "PlayerF";
            collision.gameObject.GetComponent<SpriteRenderer>().sprite = playeWF;
            door.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            door.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }
}
