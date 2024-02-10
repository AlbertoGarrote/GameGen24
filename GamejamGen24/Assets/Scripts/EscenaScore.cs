using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaScore : MonoBehaviour
{
    public GameObject TextoScore;

    public GameObject entrada;

    public GameObject salida;
    void Start()
    {
        StartCoroutine(EscenaFinal());
    }

    IEnumerator EscenaFinal()
    {
        entrada.SetActive(true);
        yield return new WaitForSeconds(1f);
        entrada.SetActive(false);
        yield return new WaitForSeconds(1.7f);
        TextoScore.SetActive(true);

    }
    public void VolverAlMenu()
    {
        StartCoroutine(VolverMenu());
    }
    IEnumerator VolverMenu()
    {
        salida.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
}
