using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfHighscore : MonoBehaviour
{
    public static float Infprimer;
    public TextMeshProUGUI Infhighscore;

    public static bool InfboolGuardar;

    private void Awake()
    {
        Infhighscore.text = PlayerPrefs.GetFloat("Infhighscore", 0).ToString("f0");

    }

    public void GuardarPuntuacionesInf()
    {
        PlayerPrefs.SetFloat("Infhighscore", Infprimer);
    }

    private void Update()
    {
        if (InfboolGuardar == true)
        {
            StartCoroutine(guardarCosasInf());
        }
    }

    IEnumerator guardarCosasInf()
    {
        GuardarPuntuacionesInf();
        InfboolGuardar = false;
        yield return null;
    }
}
