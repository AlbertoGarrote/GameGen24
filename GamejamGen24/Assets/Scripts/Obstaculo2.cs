using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo2 : MonoBehaviour
{
    public float speed = 3.0f;

    private Rigidbody2D rb;

    private Vector2 screenbounds;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(corrutinaMovimiento());
    }

    void Update()
    {
        if (transform.position.y > screenbounds.y * 1.5f || transform.position.x > 6f || transform.position.x < -6f)
        {
            Destroy(this.gameObject);
        } 
    }

    IEnumerator corrutinaMovimiento() 
    {
        rb.velocity = new Vector2(-2, speed);
        spriteRenderer.flipX = false;
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector2(2, speed);
        spriteRenderer.flipX = true;
        yield return new WaitForSeconds(1f);
    }
}
