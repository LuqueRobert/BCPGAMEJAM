using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI dineros;
    private int puntaje;

    //Instancia para publicar funciones a otros scripts
    public static Contador instancia;

    void Start()
    {
        dineros = gameObject.GetComponent<TextMeshProUGUI>();
        if(instancia == null)
        {
            instancia = this;
        }
        sumarPuntos(0);
    }
    public void sumarPuntos(int moneda)
    {
        puntaje += moneda;
        dineros.text = puntaje.ToString();
    }
    public void restarPuntos(int danio)
    {
        puntaje -= danio;
        dineros.text = puntaje.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
