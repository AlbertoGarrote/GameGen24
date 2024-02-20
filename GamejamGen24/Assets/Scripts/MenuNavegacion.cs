using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavegacion : MonoBehaviour
{
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
        StartCoroutine(salida2());
    }

    public void Salir()
    {
        StartCoroutine(salidaGeneral());
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
    IEnumerator salida2()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(5);
    }
    IEnumerator salidaGeneral()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        Application.Quit();
        Debug.Log("SALIR...");
    }
}
