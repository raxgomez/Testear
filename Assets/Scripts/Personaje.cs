using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float velocidadMouse = 100f;
    public Transform personaje;
    float Rotacionx = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float valorx = Input.GetAxis("Mouse X") * velocidadMouse * Time.deltaTime;
        float valory = Input.GetAxis("Mouse Y") * velocidadMouse * Time.deltaTime;

        Rotacionx -= valory;
        Rotacionx = Mathf.Clamp(Rotacionx, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Rotacionx, 0f, 0f);
        personaje.Rotate(Vector3.up * valorx);
    }
}
