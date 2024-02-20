using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfTimer : MonoBehaviour
{
    public static float timer = 0;

    public TextMeshProUGUI textoTimerPro;

    public TextMeshProUGUI textoPuntuacion;

    public GameObject entrada;

    public GameObject salida;

    public GameObject ContadorVidas;

    public GameObject vida1;

    public GameObject vida2;

    public GameObject vida3;

    public static bool cambioEscena;

    private void Start()
    {
        timer = 0;
        StartCoroutine(entrada1());
    }
    void Update()
    {
        if (ContadorVidas.transform.childCount == 0)
        {
            StartCoroutine(salida1());
        }
        else
        {
            timer += Time.deltaTime * 13f;
            textoTimerPro.text = "" + timer.ToString("f0");
        }
        if (InfPlayerLife.ContadorVidas1 == 1) 
        {
            Destroy(vida1);
        }
        if (InfPlayerLife.ContadorVidas1 == 2)
        {
            Destroy(vida2);
        }
        if (InfPlayerLife.ContadorVidas1 == 3)
        {
            Destroy(vida3);
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
        actualizarHighscoreInf();
        cambioEscena = true;
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        cambioEscena = false;
    }

   private void actualizarHighscoreInf()
    {
        if (timer > InfHighscore.Infprimer)
        {
            InfHighscore.Infprimer = timer;
            InfHighscore.InfboolGuardar = true;
        }
    }
}
