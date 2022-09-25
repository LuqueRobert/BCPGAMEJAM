using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porky : MonoBehaviour
{
    private Rigidbody2D playerRB;
    public int damage = 5;
    [SerializeField] private GameObject floatingTextPrefab;

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
            string s;
            s = 5.ToString();
            Debug.Log("hola");
            ShowDamage(s);
            Contador.instancia.restarPuntos(5);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.CompareTag("mrGasto2"))
        {
            string s;
            s = 5.ToString();
            Debug.Log(s);

            ShowDamage(s);
            Contador.instancia.restarPuntos(5);
            Destroy(collision.gameObject);
            

        }
    }

    void ShowDamage(string text)
    {
        Debug.Log(text);

        if(floatingTextPrefab)
        {
            GameObject textPrefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            Debug.Log(textPrefab.GetComponentInChildren<TextMesh>());

            textPrefab.GetComponentInChildren<TextMesh>().text = "-"+text;

        }
    }

    /*
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
    */

}
