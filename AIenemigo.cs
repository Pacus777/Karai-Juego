using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIenemigo : MonoBehaviour
{


    public NavMeshAgent Monstruo;
    public float Velocidad;
    public bool Persiguiendo;
    public float Rango;
    public float Distancia;
    public Transform Objetivo;

    // Update is called once per frame
    [Header("Animaciones")]
    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionQuieto;

    private void Update()
    {
        Distancia = Vector3.Distance(Monstruo.transform.position, Objetivo.position);

        if (Distancia < Rango)
        {
            Persiguiendo = true;
        }
        else if (Distancia > Rango + 3)
        {
            Persiguiendo = false;
        }

        if (Persiguiendo == false)
        {
            Monstruo.speed = 0;
            //Anim.CrossFade(NombreAnimacionQuieto);
        }
        else if (Persiguiendo == true)
        {
            Monstruo.speed = Velocidad;
            //Anim.CrossFade(NombreAnimacionCaminar);

            Monstruo.SetDestination(Objetivo.position);
        }
    } 
    
    private void OnDrawGuizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(Monstruo.transform.position, Rango);
    }
}