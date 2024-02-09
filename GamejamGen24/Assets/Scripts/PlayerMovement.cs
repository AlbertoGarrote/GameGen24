using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float xSpeed = 4;

    Rigidbody2D rb2d;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        Cursor.visible = false;
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d") && transform.position.x < 5f)
        {
            rb2d.velocity = new Vector2(xSpeed, 0);
            spriteRenderer.flipX = false;
            
        } 
        else if (Input.GetKey("a") && transform.position.x > -5f)
        {
            rb2d.velocity = new Vector2(-xSpeed, 0); 
            spriteRenderer.flipX = true;
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0); 
        }
    }
}
