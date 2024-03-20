using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb2d;

    public bool facingRight = true;

    private Vector2 moveInput;


    void FixedUpdate()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");    //get x input from user - A and D keys
        moveInput.y = Input.GetAxisRaw("Vertical");      //get y input from user - W and S keys

        rb2d.MovePosition(rb2d.position + moveInput * moveSpeed * Time.fixedDeltaTime);   //move character according to speed and what directional key user pushes

        if (moveInput.x > 0 && !facingRight)   //player is moving to the right and not facing right
        {
            Flip();
        }

        else if (moveInput.x < 0 && facingRight)   //player is moving to the left and facing right
        {
            Flip();
        }
    }

    void Flip()     //flip function that flips player sprite
    {
        Vector3 currentScale = rb2d.transform.localScale;   //create new vector variable and set it to the current scale of the player
        currentScale.x *= -1;    //multiply current player scale by -1 to flip --  -1 flips player to left and 1 flips player to right
        rb2d.transform.localScale = currentScale;   //set player scale to the new scale to flip

        facingRight = !facingRight;
    }
}
