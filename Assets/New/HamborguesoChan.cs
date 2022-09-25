using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamborguesoChan : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool bajada;
    private GameObject personaje;

    void Start()
    {
        bajada = true;
    }

    void Update()
    {
        if (bajada == true) 
        {
            transform.position += -transform.up * Time.deltaTime * speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("hastaAqui"))
        {
            bajada = false;
        }

    }
}
