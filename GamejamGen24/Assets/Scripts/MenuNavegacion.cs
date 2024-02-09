using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavegacion : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;

    public GameObject entrada;

    public GameObject salida;

    private void Start()
    {
        StartCoroutine(entrada1());
    }

    public void Jugar()
    {
        StartCoroutine(salida1());
        

    }

    public void JugarInfinite()
    {
        SceneManager.LoadScene(3);
  
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        StartCoroutine(salidaGeneral());
        
    }

    void Update()
    {
        textoPuntuacion.text = "" + Timer.puntuacion.ToString("f0");
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
        SceneManager.LoadScene(3);
    }
    IEnumerator salidaGeneral()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        Application.Quit();
        Debug.Log("SALIR...");
    }
}
