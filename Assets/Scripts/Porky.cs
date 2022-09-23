using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porky : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private GameObject prefabsA;
    private int suma = 10;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("mrGasto"))
        {
            suma++;
            Debug.Log("Esta tocando al Mister: " + suma);
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int suma = 10;
        if (collision.gameObject.CompareTag("mrGasto"))
        {
            suma++;
            Debug.Log("Esta tocando al Mister" + suma);
            Destroy(collision.gameObject);
        }

    }

}
