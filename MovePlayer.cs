using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float speed = 15f;
    public float MinSpeed = 15f;
    public float MaxSpeed = 25f;


    Animator anim;

    //movimiento de camara 
    public float Sensibility = 2f;
    public float LimitX = 45;
    public Transform cam;


    private float rotationX;
    private float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        anim.SetFloat("movimientos", 0, 0.1f, Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = MaxSpeed;
            anim.SetFloat("movimientos", 1, 0.1f, Time.deltaTime);
        } else
        {
            speed = MinSpeed;

            anim.SetFloat("movimientos", 0.5f, 0.1f, Time.deltaTime);
        }
        

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");


        if (x == 0 && y == 0)
        {
            anim.SetFloat("movimientos", 0, 0.1f, Time.deltaTime); // animación de estar quieto
        }
        
        transform.Translate(new Vector3(x, 0, y) * Time.deltaTime * speed);

        //camara
        rotationX += -Input.GetAxis("Mouse Y") * Sensibility;
        rotationX = Mathf.Clamp(rotationX, -LimitX, LimitX);
        cam.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * Sensibility, 0);
    }
}
