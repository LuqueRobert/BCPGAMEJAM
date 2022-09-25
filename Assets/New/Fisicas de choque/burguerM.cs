using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burguerM : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private float xVelocity;
    [SerializeField] private float veloHamgurguer = 5f;
    private int coins;
    public static burguerM instanciaBurguer;
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        Launch();

        if (instanciaBurguer == null)
        {
            instanciaBurguer = this;
        }
    }
    public void velocityBurguer(int monedas)
    {
        veloHamgurguer = 5f;
        monedas = coins;

        
        if (monedas >= 500 && monedas < 750)
        {
            veloHamgurguer = 10f;
        }
        else if (monedas >= 750)
        {
            veloHamgurguer = 30f;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("paredLeft"))
        {
            ballRb.velocity = new Vector2(1, -1) * veloHamgurguer;
        }

        if (collision.gameObject.CompareTag("paredRight"))
        {
            ballRb.velocity = new Vector2(-1, -1) * veloHamgurguer;
        }

    }
    private void Launch()
    {
        xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRb.velocity = new Vector2(xVelocity, -1) * veloHamgurguer;

        //Contador.instancia.enviarCoinsBurguer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
