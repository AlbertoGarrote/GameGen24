using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("NUBE"))
        {
            Timer.puntuacion -= 5.0f;
        }
        else if (collision.transform.CompareTag("PALOMO"))
        {
            Timer.puntuacion -= 7.0f;
        }
        else if (collision.transform.CompareTag("OVNI"))
        {
            Timer.puntuacion -= 10.0f;
        }

        else if (collision.transform.CompareTag("ObstaculoBueno"))
        {
            Timer.puntuacion += 20.0f;

        }
    }
    
}
