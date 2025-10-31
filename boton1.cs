using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boton1 : MonoBehaviour
{
     public int numeroEscena;

    public void iniciar()
    {
        SceneManager.LoadScene(numeroEscena);
    }
}
