using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavegacion : MonoBehaviour
{
    public static int modoDeJuego;

    public TextMeshProUGUI textoPuntuacion;
    public void Jugar()
  {
        SceneManager.LoadScene(1);
        modoDeJuego = 0;
    }

    public void JugarInfinite()
    {
        SceneManager.LoadScene(3);
        modoDeJuego = 1;
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("SALIR...");
    }

    void Update()
    {
        textoPuntuacion.text = "" + Timer.puntuacion.ToString("f0");
    }
}
