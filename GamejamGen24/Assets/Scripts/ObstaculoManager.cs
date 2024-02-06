using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoManager : MonoBehaviour
{
    public GameObject ObjetoPrefab;
    //public float respawnTime = Random.Range(0.2f, 0.6f);
    public bool activarSpawn = true;
    private Vector2 screenbounds;

    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(corrutinaSpawn());
    }

    private void SpawnObtaculo()
    {
        GameObject a = Instantiate(ObjetoPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-6f, 6f), screenbounds.y * -2);
    }

    IEnumerator corrutinaSpawn()
    {
        while(activarSpawn)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 0.75f));
            SpawnObtaculo();
        }
    }

}
