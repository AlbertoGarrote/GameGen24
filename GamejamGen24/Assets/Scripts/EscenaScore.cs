using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaScore : MonoBehaviour
{
    public GameObject TextoScore;

    public GameObject entrada;

    public GameObject salida;

    public AudioClip winwin;

    public AudioClip salide;

    public AudioClip metalPipe;

    public TextMeshProUGUI textoPuntuacionFinal;

    public GameObject TextoPuntuacionPanel;


    void Start()
    {
        StartCoroutine(EscenaFinal());
    }

    IEnumerator EscenaFinal()
    {
        entrada.SetActive(true);
        ControladorSonido.Instance.EjecutarSonido(salide);
        yield return new WaitForSeconds(1f);
        entrada.SetActive(false);
        ControladorSonido.Instance.EjecutarSonido(winwin);
        TextoPuntuacionPanel.SetActive(true);
        textoPuntuacionFinal.text = "" + Timer.puntuacionFinal.ToString("f0");
        TextoScore.SetActive(true);
        yield return new WaitForSeconds(12f);
        ControladorSonido.Instance.EjecutarSonido(metalPipe);

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
