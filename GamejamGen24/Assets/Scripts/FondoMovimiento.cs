using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovi;

    private Vector2 offset;

    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        Cursor.visible = false;
    }

    private void Update()
    {
        offset = velocidadMovi * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
