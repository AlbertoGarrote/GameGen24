using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static float primer;
    public TextMeshProUGUI highscore;

    public static bool boolGuardar;

    private void Awake()
    {
        highscore.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");

    }

    public void GuardarPuntuaciones()
    {
        PlayerPrefs.SetFloat("highscore", primer);
    }

    private void Update()
    {
        if (boolGuardar == true) 
        {
            StartCoroutine(guardarCosas());
        }
    }

    IEnumerator guardarCosas()
    {
        GuardarPuntuaciones();
        boolGuardar = false;
        yield return null;
    }
}

