using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nubes : MonoBehaviour
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
        nubecita.transform.position = posicionInicial;
    }

    void Update()
    {
        // Mueve la imagen hacia la derecha
        if (moviendoseDerecha)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado la posición final
            if (transform.position.x >= posicionFinal.x)
            {
                moviendoseDerecha = false;
            }
        }
        // Regresa la imagen a la posición inicial
        else
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            // Verifica si ha alcanzado la posición inicial
            if (transform.position.x <= posicionInicial.x)
            {
                moviendoseDerecha = true;
            }
        }
    }
}
