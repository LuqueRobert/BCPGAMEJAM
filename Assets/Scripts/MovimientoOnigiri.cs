using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoOnigiri : MonoBehaviour
{

    private float veloOnigiri = 5f;
    private GameObject personaje;
    public static MovimientoOnigiri instanciaOni;
    private  int monedas;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        if (instanciaOni == null)
        {
            instanciaOni = this;
        }
        Contador.instancia.enviarCoinsOnigiri();
        ControllerEnemys.instanciaControl.enviarCountOni();
    }
    public void contador(int countOnigiri)
    {
        count = countOnigiri;
    }

    public void velocidadOnigiri(int coins)
    {
        monedas = coins;

        if (monedas >= 10 && monedas < 200)
        {
            veloOnigiri = 10f;
        }
        else if (monedas >= 200 && monedas < 500)
        {
            veloOnigiri = 15f;
        }
        else if (monedas >= 500 && monedas < 750)
        {
            veloOnigiri = 20f;
        }
        else if (monedas >= 750)
        {
            veloOnigiri = 20f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * veloOnigiri;
    }
}
