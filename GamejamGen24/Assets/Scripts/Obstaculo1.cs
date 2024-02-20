using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo1 : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody2D rb;

    private Vector2 screenbounds;

    public AudioClip nube;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    void Update()
    {
        if(transform.position.y > screenbounds.y * 1.5f || transform.position.x > 5f || transform.position.x < -5f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(nube);
            Destroy(this.gameObject);
        }
    }
}
