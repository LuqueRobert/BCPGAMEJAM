using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    [SerializeField] private int valorCoin = 10;

    private AudioControler soundManager;
    void Start()
    {
        
    }

    void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);

                var kill = hitInfo.transform.gameObject.name;
                var otro = hitInfo.transform.gameObject;


                string indentificar = kill.Substring(0, 4);


                if (indentificar == "coin")
                {
                    AudioControler.instancia.seleccionado(0, 1f);
                    Contador.instancia.sumarPuntos(valorCoin);
                    Destroy(otro, .0f);

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


                string indentificar = kill.Substring(0, 4);


                if (indentificar == "coin")
                {
                    AudioControler.instancia.seleccionado(0, 1f);
                    Contador.instancia.sumarPuntos(valorCoin);
                    Destroy(otro, .0f);

                }

            }
        }
    }
}
