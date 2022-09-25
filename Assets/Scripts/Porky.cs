using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porky : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private GameObject prefabsA;
    [Header("Para que se ponga feliz")]
    public static Porky porkyfeliz;

    [Header("Animacion")]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        if (porkyfeliz == null)
        {
            porkyfeliz = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetBool("Triste",danio);
    }
    public void happy()
    {
        animator.SetTrigger("Feliz");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //danio = true;
        animator.SetTrigger("enemyD");
        if (collision.gameObject.CompareTag("mrGasto"))
        {
            Contador.instancia.restarPuntos(15);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("mrGasto2"))
        {
            Contador.instancia.restarPuntos(10);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Hamborguesos"))
        {
            Contador.instancia.restarPuntos(5);
            Destroy(collision.gameObject);
        }
    }

}
