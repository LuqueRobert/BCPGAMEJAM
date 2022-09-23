using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemies;

    public float tiempoDeSpawm = 2;
    public float repetirSpawm = 3;

    public Transform xRangeLeft;
    public Transform xRangeRight;
    public Transform yRangeUp;
    public Transform yRangeDown;

    void Start()
    {
        //Metodo para poder repetir una funcion, cuantasVeces, Cada cuantos segundos
        InvokeRepeating("spawm", tiempoDeSpawm, repetirSpawm);   
    }

    public void spawm()
    {
        Vector3 posicion1 = new Vector3(0, 0, 0);
      

        posicion1 = new Vector3(Random.Range(xRangeLeft.position.x,xRangeRight.position.x), Random.Range(yRangeDown.position.y,yRangeUp.position.y),0);
       
        GameObject enemigos = Instantiate(enemies[0],posicion1,gameObject.transform.rotation);
         
    }
}
