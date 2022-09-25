using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHamborguesos : MonoBehaviour
{
    public GameObject[] enemies;

    public float tiempoDeSpawm = 60;
    public float repetirSpawm = 60;

    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    private int count;
    [Header("Traer")]
    public static SpawnerHamborguesos instanciaHambur;
    private int niaa;

    void Start()
    {
        //Metodo para poder repetir una funcion, cuantasVeces, Cada cuantos segundos
        
        if (instanciaHambur == null)
        {
            instanciaHambur = this;
        }
        InvokeRepeating("spawm", tiempoDeSpawm, repetirSpawm);
    }
    public void comenzarH(float tS, float rS)
    {
        tiempoDeSpawm = tS;
        repetirSpawm = rS;
        niaa++;
        if(niaa == 1)
        {
            InvokeRepeating("spawm", tiempoDeSpawm, repetirSpawm);
        }
    }
    public void spawm()
    {

        Vector3 posicion1 = new Vector3(0, 0, 0);

        posicion1 = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject enemigos = Instantiate(enemies[Random.Range(0, enemies.Length)], posicion1, gameObject.transform.rotation) as GameObject;

        enemigos.name = "hambo" + count++;

    }
}
