using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo3 : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rb;

    private Vector2 screenbounds;

    public SpriteRenderer spriteRenderer;

    public AudioClip ovni;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-3f, 3f), speed);
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        if (transform.position.y > screenbounds.y * 1.5f || transform.position.x > screenbounds.x || transform.position.x < -screenbounds.x)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(ovni);
            Destroy(this.gameObject);
        }
    }
}
