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
                    Debug.Log(hitInfo.transform.gameObject.name);
                    var kill = hitInfo.transform.gameObject.name;
                    if (kill == "mrGastos(Clone)")
                    {
                        Destroy(gameObject, .0f);

                    }
                }
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(pos), Vector2.zero);
            // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
            if (hitInfo)
            {
                Debug.Log(hitInfo.transform.gameObject.name);
                var kill = hitInfo.transform.gameObject.name;
                if(kill == "mrGastos(Clone)")
                {
                    Destroy(gameObject, .0f);

                }
                // Here you can check hitInfo to see which collider has been hit, and act appropriately.

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

    }*/

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Dinero"))
        {
            Debug.Log("SIUU");
        }
    }
}
