using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Linterna : MonoBehaviour
{
    public Light luzLinterna; // arrastraremos la luz aquí
    private bool encendida = false;

    void Start()
    {
        // Aseguramos que empiece apagada
        luzLinterna.enabled = false;
    }

    void Update()
    {
        // Si presionamos F
        if (Input.GetKeyDown(KeyCode.F))
        {
            encendida = !encendida; // cambia estado
            luzLinterna.enabled = encendida;
        }
    }
}

