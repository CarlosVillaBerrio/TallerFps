using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    public float speed = 0.1f; // Determina la velocidad con la que se mueve el objeto
    float mouseX; // Declaracion de mouse X


    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition; // Analiza la posicion del cursor
        mouseX += Input.GetAxis("Mouse X"); // Actualiza los valores de mouseX
        transform.eulerAngles = new Vector3(0, mouseX, 0); // Actualiza la rotacion horizontal

        if (Input.GetKey(KeyCode.W)) // Condicion para moverse hacia adelante con la tecla W
        {
            transform.position += transform.forward * speed; // Transforma la posicion hacia el frente
        }
        if (Input.GetKey(KeyCode.S)) // Condicion para moverse hacia atras con la tecla S
        {
            transform.position -= transform.forward * speed; // Transforma la posicion hacia atras
        }
        if(Input.GetKey(KeyCode.A)) // Condicion para moverse hacia la izquierda con la tecla A
        {
            transform.position -= transform.right * speed; // Transforma la posicion hacia la izquierda
        }
        if (Input.GetKey(KeyCode.D)) // Condicion para moverse hacia la derecha con la tecla D
        {
            transform.position += transform.right * speed; // Transforma la posicion hacia la derecha
        }
    }
}
