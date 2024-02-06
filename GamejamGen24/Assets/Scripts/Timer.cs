using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timer = 0;

    public TextMeshProUGUI textoTimerPro;

    void Update()
    {
        if(timer > 0){
            timer -= Time.deltaTime*13f;
            textoTimerPro.text = "" + timer.ToString("f0");
        }
    }
}
