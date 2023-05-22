using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nube2 : MonoBehaviour
{
    public float velocidad = 0.3f;
    public Vector3 posicionInicial;
    public Vector3 posicionFinal;

    private bool moviendoseDerecha = true;
    public GameObject nubecita;

    void Start()
    {
        // Guarda la posición inicial de la imagen
        posicionInicial = transform.position;
        transform.position = posicionInicial; // Asigna la posición inicial al objeto actual
    }

    void Update()
    {
        // Mueve la imagen hacia la izquierda
        if (moviendoseDerecha)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado o superado la posición final
            if (transform.position.x <= posicionFinal.x)
            {
                transform.position = posicionInicial; // Establece la posición final exacta
                moviendoseDerecha = false;
            }
        }
        // Mueve la imagen hacia la derrecha
        // Mueve la imagen hacia la izquierda
        if (moviendoseDerecha)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado o superado la posición final
            if (transform.position.x <= posicionFinal.x)
            {
                transform.position = new Vector3(posicionFinal.x, transform.position.y, transform.position.z);
                moviendoseDerecha = false;
            }
        }
        // Mueve la imagen hacia la derecha
        else
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado o superado la posición inicial
            if (transform.position.x >= posicionInicial.x)
            {
                transform.position = new Vector3(posicionInicial.x, transform.position.y, transform.position.z);
                moviendoseDerecha = true;
            }
        }
    }
}
