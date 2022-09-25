using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerEnemys : MonoBehaviour
{
    [Header("Objetos Enemigos")]
    [SerializeField] private GameObject Heladitos;
    [SerializeField] private GameObject hamborguesos;

    [Header("Controller Requiere Coins D:")]
    public static ControllerEnemys instanciaControl;


    [SerializeField] private int monedas;

    [Header("Velocidades")]
    [SerializeField] private float veloHeladito;
    [SerializeField] private float veloOnigiri;
    [SerializeField] private float veloHamgurguer;

    [Header("VelocidaContinua")]
    private int count = 0;

    void Start()
    {

        if (instanciaControl == null)
        {
            instanciaControl = this;
        }
    }

    public void Coins(int coins)
    {
        monedas = coins;
        if (monedas >= 50 && monedas < 200)
        {
            if (count == 0)
            {
                count = 1;
            }
        }
        else if (monedas >= 200 && monedas < 500)
        {
            if (count == 1)
            {
                count = 2;
            }
        }
        else if (monedas >= 500 && monedas < 750)
        {
            if (count == 2)
            {
                count = 3;
            }
        }
        else if (monedas >= 750)
        {
            if (count == 3)
            {
                count = 3;
            }
        }

        if (monedas >= 180 && monedas < 500)
        {
            Spawn.instanciaSpawn.comenzar(1f, 1f);
            SpawnerHamborguesos.instanciaHambur.comenzarH(1f, 5f);
        } else if (monedas >= 500)
        {

        }
    }
    public void enviarCountHela()
    {
        MoverHeladito.instanciaHela.contador(count);
    }
    public void enviarCountOni()
    {
        MovimientoOnigiri.instanciaOni.contador(count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
