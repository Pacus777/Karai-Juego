using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaltaEscenaIntroAJuego : MonoBehaviour
{
    public int NumeroEscena;
    
    public void iniciar()
    {
        SceneManager.LoadScene(NumeroEscena);
    }


}
