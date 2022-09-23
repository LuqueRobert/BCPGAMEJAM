using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cerdito : MonoBehaviour
{
    private Rigidbody2D playerRB;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinero"))
        {
            Debug.Log("SIU");
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Esta tocando al CUY");
            Destroy(collision.gameObject);
        }

    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Dinero"))
        {
            Debug.Log("SIUU");
        }
    }
}
