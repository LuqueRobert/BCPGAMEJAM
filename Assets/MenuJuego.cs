using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuJuego : MonoBehaviour
{
    public GameObject optionPanel;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void optionsPanel()
    {
        //PARAR TIEMPO
        Time.timeScale = 0;
        optionPanel.SetActive(true);
    }
    public void Return()
    {
        Time.timeScale = 1;
        optionPanel.SetActive(false);
    }

    public void goMenu()
    {
        SceneManager.LoadScene("MenuInicial");
    }
    public void salirGame()
    {
        Application.Quit();
    }


}
