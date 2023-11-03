using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Used to handle input from Player
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate() //Used as it updates on fixed timer, rather than frame rate like update.
    {
        //Used to handle movement of player
        //Moves player by movement speed and keeps it steady by using fixed delta time, makes a constant movement speed.
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);

    }
}
