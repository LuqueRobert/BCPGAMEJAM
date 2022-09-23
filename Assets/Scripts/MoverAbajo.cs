using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAbajo : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private GameObject personaje;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * speed;
    }
}
