using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CArruselImg : MonoBehaviour
{
    public GameObject[] VINYETAS;
    public GameObject entrada;
    public GameObject salida;
    int pepito = 0;

    void Start()
    {
        VINYETAS[0].SetActive(true);
        entrada.SetActive(true);
        StartCoroutine(entrada1());
    }

    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            pepito += 1;
            if (pepito == 6)
            {
                StartCoroutine(salida1());
            }
            else
            {
                
                StartCoroutine(pasoVinyeta());
            }
        }
    }
    IEnumerator entrada1()
    {
        yield return new WaitForSeconds(0.5f);
        entrada.SetActive(false);
    }

    IEnumerator pasoVinyeta()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        VINYETAS[pepito - 1].SetActive(false);
        salida.SetActive(false);
        entrada.SetActive(true);
        VINYETAS[pepito].SetActive(true);
        yield return new WaitForSeconds(1f);
        entrada.SetActive(false);
    }

    IEnumerator salida1()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
