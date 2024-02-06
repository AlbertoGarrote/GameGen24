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
        if (collision.transform.CompareTag("ObstaculoMalo"))
        {
            Timer.puntuacion += 1.0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    
}
