using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jugadorCAM : MonoBehaviour
{
    public float velocidad = 5f;
    public float sensibilidadMouse = 2f;

    private float rotacionX = 0f;
    private Camera cam;

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked; // Oculta el cursor
    }

    void Update()
    {
        // Movimiento
        float movX = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float movZ = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(movX, 0, movZ);

        // Rotación de cámara
        float mouseX = Input.GetAxis("Mouse X") * sensibilidadMouse;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidadMouse;

        rotacionX -= mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -80f, 80f);

        cam.transform.localRotation = Quaternion.Euler(rotacionX, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);
    }


}
