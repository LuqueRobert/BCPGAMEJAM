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

    [SerializeField] private GameObject floatingTextPrefab;

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
        string s = moneda.ToString();
        if (puntaje!=0)
        {
            ShowDamage(s);
        }
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

    void ShowDamage(string text)
    {
        Debug.Log(text);

        if (floatingTextPrefab)
        {
            GameObject textPrefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            Debug.Log(textPrefab.GetComponentInChildren<TextMesh>());

            textPrefab.GetComponentInChildren<TextMesh>().text = "+" + text;

        }
    }
}
