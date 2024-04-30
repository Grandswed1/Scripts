using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float speed;
    public float input;
    public SpriteRenderer spriteRenderer;
    public float jumpForce;

    //Hindrar infinate jump/flygande. Checkar om spelaren är på marken
    public LayerMask groundLayer;
    private bool isGrounded;
    public Transform feetPosition;
    public float groundCheckCircle;

    int extraJump;
    int extraJumpValue = 2;

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");  
        //om mindre än 0. Flippa karaktären.
        if(input < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (input > 0)
        {
            spriteRenderer.flipX = false;
        }

        //ja eller nej. Är karaktären på marken eller inte. 
        isGrounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckCircle, groundLayer);
        //om man hoppar så subtractar den 1 och så har man 1 kvar att hoppa med
        if(isGrounded == true){
            extraJump = extraJumpValue;
        }
        if (isGrounded == true && Input.GetButton("Jump"))
        {
           jumpUpdate();
        }
        else if(extraJump > 0 && Input.GetKeyDown(KeyCode.Space)){
            jumpUpdate();
        } 

    }


    void FixedUpdate()
        
    {
        playerRb.velocity = new Vector2 (input * speed, playerRb.velocity.y); 
    }

    void jumpUpdate(){
        playerRb.velocity = Vector2.up * jumpForce;
        extraJump--;
    }
}
