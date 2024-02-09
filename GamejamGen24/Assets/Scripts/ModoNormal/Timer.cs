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

    public TextMeshProUGUI textoTimerPro;

    public TextMeshProUGUI textoPuntuacion;

    public GameObject entrada;

    public GameObject salida;

    private void Start()
    {
        StartCoroutine(entrada1());
    }
    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime*13f;
            textoTimerPro.text = "" + timer.ToString("f0");
            textoPuntuacion.text = "" + puntuacion.ToString("f0");
        }
        else
        {
            StartCoroutine(salida1());
        }

    }

    IEnumerator entrada1()
    {
        entrada.SetActive(true);
        yield return new WaitForSeconds(1f);
        entrada.SetActive(false);
    }
    IEnumerator salida1()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        Cursor.visible = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
