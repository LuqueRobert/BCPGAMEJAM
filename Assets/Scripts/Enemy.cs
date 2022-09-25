using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private int hamboVida;


    void Start()
    {
        hamboVida = 3;
    }
    
    
    void Update()
    {

        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);
                // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
                if (hitInfo)
                {
                    var kill = hitInfo.transform.gameObject.name;
                    var otro = hitInfo.transform.gameObject;

                    string indentificar = kill.Substring(0, 5);

                    if (indentificar == "helad")
                    {
                        Destroy(otro, .0f);
                    }
                    if (indentificar == "onigi")
                    {
                        Destroy(otro, .0f);
                    }
                    if (indentificar == "hambo")
                    {
                        hamboVida--;
                        if (hamboVida == 0)
                        {
                            Destroy(otro, .0f);
                        }
                    }

                }


            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            
            
            if (hitInfo)
            {
                var kill = hitInfo.transform.gameObject.name;
                var otro = hitInfo.transform.gameObject;

                string indentificar = kill.Substring(0, 5);

                if (indentificar == "helad")
                {
                    Destroy(otro, .0f);
                }
                if (indentificar == "onigi")
                {
                    Destroy(otro, .0f);
                }
                if (indentificar == "hambo")
                {
                    hamboVida--;
                    if (hamboVida == 0)
                    {
                        Destroy(otro, .0f);
                    }
                }
            }
        }

    }
    /*
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

   

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Dinero"))
        {
            Debug.Log("SIUU");
        }
    }
     }*/
}
