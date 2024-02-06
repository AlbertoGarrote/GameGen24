using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoManager : MonoBehaviour
{
    public GameObject ObjetoPrefab;
    public float respawnTime = 0.5f;
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
        a.transform.position = new Vector2(Random.Range(-screenbounds.x, screenbounds.x), screenbounds.y * -2);
    }

    IEnumerator corrutinaSpawn()
    {
        while(activarSpawn)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnObtaculo();
        }
    }

}
