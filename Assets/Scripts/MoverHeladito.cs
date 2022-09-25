using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHeladito : MonoBehaviour
{
    private float veloHeladito = 3f;
    private GameObject personaje;
    public static MoverHeladito instanciaHela;
    [SerializeField]private int monedas;

    [SerializeField]private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instanciaHela == null)
        {
            instanciaHela = this;
        }
        Contador.instancia.enviarCoinsHeladito();
        ControllerEnemys.instanciaControl.enviarCountHela();
    }
    public void contador(int countHeladito)
    {
        count = countHeladito;
    }
    public void velocidadHeladito(int coins)
    {
        monedas = coins;

        if (monedas >= 50 && monedas < 200 && count == 0)
        {
            veloHeladito = 7f;
        }
        else if (monedas >= 200 && monedas < 500 && count == 1)
        {
            veloHeladito = 13f;
        }
        else if (monedas >= 500 && monedas < 750 && count == 2)
        {
            veloHeladito = 17f;
        }
        else if (monedas >= 750 && count == 3)
        {
            veloHeladito = 18f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * veloHeladito;
    }
}
