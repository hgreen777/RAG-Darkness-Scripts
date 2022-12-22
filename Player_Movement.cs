using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movespeed = 150f;        //player speed
    public Rigidbody2D rb;      //reference to rigid body

    private Vector2 movement; // sets horizontal and vertical components

    // Update is called once per frame
    void Update()
    {
        //Input manager
        movement.x = Input.GetAxisRaw("Horizontal"); // Output = -1 to 1, pressing left = -1, pressing right = 1
        movement.y = Input.GetAxisRaw("Vertical");
        movement.Normalize();

    }

    //Fixed timer (50 times per second)
    void FixedUpdate()
    {
        //Movement manager
        rb.velocity = movement * movespeed * Time.fixedDeltaTime; // current position + input * movespeed * constant move speed
        
    }
}
