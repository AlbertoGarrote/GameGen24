using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject MenuPausaObj;
    public GameObject MenuPausaBoton;

    void Start()
    {
        MenuPausaObj.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Timer.cambioEscena == false && InfTimer.cambioEscena == false)
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        MenuPausaBoton.SetActive(false);
        MenuPausaObj.SetActive(true);
        Time.timeScale = 0f;
        Cursor.visible = true;
    }

    public void ResumeGame()
    {
        MenuPausaBoton.SetActive(true);
        MenuPausaObj.SetActive(false);
        Time.timeScale = 1f;
      
        Cursor.visible = false;
    }
    public void ResumeGamePRINCIPAL()
    {
        MenuPausaBoton.SetActive(true);
        MenuPausaObj.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Salir()
    {
        Cursor.visible = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
    }
}
