using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemies;

    public float tiempoDeSpawm = 1;
    public float repetirSpawm = 5;

    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    private int count;
    [Header("Encabezado de exportacion de articulos :D")]
    public static Spawn instanciaSpawn;
    private int niaa;
    
    void Start()
    {
        if (instanciaSpawn == null)
        {
            instanciaSpawn = this;
        }
        //Metodo para poder repetir una funcion, cuantasVeces, Cada cuantos segundos
        InvokeRepeating("spawm", 1, 5);
    }
    public void comenzar(float tS, float rS)
    {
        tiempoDeSpawm = tS;
        repetirSpawm = rS;
        niaa++;
        if (niaa == 1)
        {
            InvokeRepeating("spawm", tiempoDeSpawm, repetirSpawm);
        }
    }

    public void spawm()
    {
        int randon = Random.Range(0, enemies.Length);
        Vector3 posicion1 = new Vector3(0, 0, 0);


        posicion1 = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject enemigos = Instantiate(enemies[randon], posicion1, gameObject.transform.rotation) as GameObject;

        if (randon == 0)
        {
            enemigos.name = "helad" + count++;
        }
        else
        {
            enemigos.name = "onigi" + count++;
        }
    }
}
