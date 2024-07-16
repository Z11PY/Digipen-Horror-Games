using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] private Rigidbody2D playerRb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        playerRb.velocity = new Vector2(horizontalInput * speed, forwardInput * speed);

        transform.up = playerRb.velocity.normalized * rotationSpeed * Time.deltaTime;
    }
}
