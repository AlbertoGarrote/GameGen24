using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public static float puntuacion = 0;

    public static float puntuacionFinal;

    public TextMeshProUGUI textoTimerPro;

    public TextMeshProUGUI textoPuntuacion;

    public GameObject entrada;

    public GameObject salida;

    public static bool cambioEscena;

    private void Start()
    {
        puntuacion = 0;
        StartCoroutine(entrada1());
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime * 13f;
            textoTimerPro.text = "" + timer.ToString("f0");
            textoPuntuacion.text = "" + puntuacion.ToString("f0");
        }
        else
        {
            puntuacionFinal = puntuacion;
            StartCoroutine(salida1());
        }

    }

    IEnumerator entrada1()
    {
        cambioEscena = true;
        entrada.SetActive(true);
        yield return new WaitForSeconds(1f);
        entrada.SetActive(false);
        cambioEscena = false;
    }
    IEnumerator salida1()
    {
        actualizarHighscore();
        cambioEscena = true;
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        cambioEscena = false;
    }

    private void actualizarHighscore()
    {
        if (puntuacionFinal > HighScore.primer)
        {
            HighScore.primer = puntuacionFinal;
            HighScore.boolGuardar = true;
        }
    }
}
