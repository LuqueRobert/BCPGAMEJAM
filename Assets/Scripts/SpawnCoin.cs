using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject[] enemies;

    public float tiempoDeSpawm = 2;
    public float repetirSpawm = 3;

    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    private int count = 0;
    
    void Start()
    {
        //Metodo para poder repetir una funcion, cuantasVeces, Cada cuantos segundos
        InvokeRepeating("spawm", tiempoDeSpawm, repetirSpawm);
    }

    public void spawm()
    {
        int rEnemy = Random.Range(0, enemies.Length);

        Vector3 posicion1 = new Vector3(0, 0, 0);


        posicion1 = new Vector3(Random.Range(xRangeLeft.position.x, xRangeRight.position.x), Random.Range(yRangeDown.position.y, yRangeUp.position.y), 0);

        GameObject coins = Instantiate(enemies[rEnemy], posicion1, gameObject.transform.rotation) as GameObject;

        coins.name = "coin" + count++;
       

    }
}
