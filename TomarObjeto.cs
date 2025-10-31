using UnityEngine;

public class TomarObjeto : MonoBehaviour
{
    public float distancia = 3f;
    public Transform puntoSujecion; // lugar donde se sujetará el objeto
    private GameObject objetoTomado;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objetoTomado == null)
            {
                // Intentar tomar objeto frente al jugador
                Ray rayo = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                RaycastHit hit;

                if (Physics.Raycast(rayo, out hit, distancia))
                {
                    if (hit.collider.CompareTag("Tomable"))
                    {
                        objetoTomado = hit.collider.gameObject;
                        objetoTomado.transform.SetParent(puntoSujecion);
                        objetoTomado.transform.localPosition = Vector3.zero;
                        objetoTomado.GetComponent<Rigidbody>().isKinematic = true;
                    }
                }
            }
            else
            {
                // Soltar objeto
                objetoTomado.GetComponent<Rigidbody>().isKinematic = false;
                objetoTomado.transform.SetParent(null);
                objetoTomado = null;
            }
        }
    }
}
