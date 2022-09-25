using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConffetiStart : MonoBehaviour
{

    ParticleSystem conffeti;

    // Start is called before the first frame update
    void Start()
    {
        conffeti = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnConffeti(Collider other)
    {
        conffeti.Play();
    }
}
