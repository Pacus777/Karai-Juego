using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarJuego()
    {
        // Carga la siguiente escena (asegúrate de agregarla en Build Settings)
        SceneManager.LoadScene("SampleScene");
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Funciona al compilar el juego
    }
}

