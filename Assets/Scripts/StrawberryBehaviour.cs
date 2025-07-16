using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryBehaviour : MonoBehaviour
{
    public GameObject go;
    public GameController gc;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gc.StrawberryCount++;
            go.SetActive(false);
        }
    }
}
