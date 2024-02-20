using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo2 : MonoBehaviour
{
    public float speed = 8.0f;

    private Rigidbody2D rb;

    private Vector2 screenbounds;

    public SpriteRenderer spriteRenderer;

    public AudioClip palomo;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
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
        rb.velocity = new Vector2(2f, speed);
        spriteRenderer.flipX = true;
        yield return new WaitForSeconds(Random.Range(0.8f, 1.5f));
        rb.velocity = new Vector2(-2f, speed);
        spriteRenderer.flipX = false;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(palomo);
            Destroy(this.gameObject);
        }
    }
}
