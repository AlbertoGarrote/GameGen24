using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(logoloco());
    }

    IEnumerator logoloco()
    {

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
