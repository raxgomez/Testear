using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    CharacterController controller;

    public float velocidadCaminar = 6f;
    public float velocidadCorrer = 10f;
    public float velocidadSalto = 8f;
    public float Gravedad = 15f;

    private Vector3 movimiento = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded)
        {
            movimiento = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

            if(Input.GetKey(KeyCode.LeftShift))
            {
                movimiento = transform.TransformDirection(movimiento) * velocidadCorrer;
            } else
                movimiento = transform.TransformDirection(movimiento) * velocidadCaminar;
        }
        movimiento.y -= Gravedad * Time.deltaTime;

        controller.Move(movimiento * Time.deltaTime);
    }
}
