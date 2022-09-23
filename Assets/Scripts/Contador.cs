using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI dineros;
    public int puntaje;
    void Start()
    {
        dineros = gameObject.GetComponent<TextMeshProUGUI>();
        sumarPuntos();
    }
    public void sumarPuntos()
    {
        puntaje++;
        dineros.text = puntaje.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
