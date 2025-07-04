using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jump = 15f; // valor razoável de pulo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Pulando");
            rb.AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
        }

    }
}
