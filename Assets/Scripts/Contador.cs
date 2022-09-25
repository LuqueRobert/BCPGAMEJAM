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

    [Header("Codigo Bestia en camino")]
    [SerializeField] private int codigoBestia;
    void Start()
    {
        dineros = gameObject.GetComponent<TextMeshProUGUI>();
        if (instancia == null)
        {
            instancia = this;
        }
        sumarPuntos(0);
    }
    public void enviarCoinsHeladito()
    {
        MoverHeladito.instanciaHela.velocidadHeladito(puntaje);
    }
    public void enviarCoinsOnigiri()
    {
        MovimientoOnigiri.instanciaOni.velocidadOnigiri(puntaje);
    }
    /*
    public void enviarCoinsBurguer()
    {
        burguerM.instanciaBurguer.velocityBurguer(puntaje);
    }
    */
    public void sumarPuntos(int moneda)
    {
        Porky.porkyfeliz.happy();
        puntaje += moneda;
        dineros.text = puntaje.ToString();

        ControllerEnemys.instanciaControl.Coins(puntaje);
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
