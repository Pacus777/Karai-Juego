using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float speed = 15f;
    public float MinSpeed = 15f;
    public float MaxSpeed = 25f;


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
    }

    // Update is called once per frame
    void Update()
    {
        //move character

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = MaxSpeed;
        } else
        {
            speed = MinSpeed;
        }
        

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x, 0, y) * Time.deltaTime * speed);

        //camara
        rotationX += -Input.GetAxis("Mouse Y") * Sensibility;
        rotationX = Mathf.Clamp(rotationX, -LimitX, LimitX);
        cam.localRotation = Quaternion.Euler(rotationX, 0, 0);
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * Sensibility, 0);
    }
}
