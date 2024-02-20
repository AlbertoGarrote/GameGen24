using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfPlayerLife : MonoBehaviour
{
    Rigidbody2D rb2d;
    public static int ContadorVidas1;

    void Start()
    {
        ContadorVidas1 = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (InfTimer.cambioEscena == false)
        {
            if (collision.transform.CompareTag("matador"))
            {
                ContadorVidas1 += 1;
                Debug.Log(ContadorVidas1);
            }
        }  
    }
    
}
