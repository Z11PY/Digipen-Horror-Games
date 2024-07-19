using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const int V = 1;
    public float speed = 3;
    public float rotationSpeed;
    public float sprintSpeed = 5;
    public float stamina = 100;
    public float staminaDrain;
    public bool isSprinting;
    private float horizontalInput;
    private float forwardInput;
    [SerializeField] private Rigidbody2D playerRb;

    //if script is broken delete lines 18 and 19 >Rasa
    private Animation anim;
    public bool isWalking;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        sprintSpeed = 5;
        //
        anim = gameObject.GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        playerRb.velocity = new Vector2(horizontalInput * speed, forwardInput * speed);

        transform.up = playerRb.velocity.normalized * rotationSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftShift) && stamina >= 0)
        {
            speed = sprintSpeed;
            isSprinting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && stamina <= 100)
        {
            speed = 3;
            isSprinting = false;
        }

        if (isSprinting == true)
        {
            stamina -= staminaDrain;
        }

        if (isSprinting == false)
        {
            stamina += 10;
        }
        

    }

}
