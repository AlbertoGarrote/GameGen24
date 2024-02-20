using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    Rigidbody2D rb2d;

    public static int ContadorVidas1;


    void Start()
    {
        ContadorVidas1 = 0;
        rb2d = GetComponent<Rigidbody2D>();
        Timer.puntuacion = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (Timer.cambioEscena == false)
        {
            if (Timer.cambioEscena == false)
            {
                if (collision.transform.CompareTag("NUBE"))
                {
                    Timer.puntuacion -= 5;
                }
                else if (collision.transform.CompareTag("PALOMO"))
                {
                    Timer.puntuacion -= 7;
                }
                else if (collision.transform.CompareTag("OVNI"))
                {
                    Timer.puntuacion -= 10;
                }

                else if (collision.transform.CompareTag("ObstaculoBueno"))
                {
                    Timer.puntuacion += 20;

                }
            }
        }
    }

}
