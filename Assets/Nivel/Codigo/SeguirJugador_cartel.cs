using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador_cartel : MonoBehaviour
{
    public GameObject Personaje;

    private Vector3 initialCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        initialCameraPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = -7.5f; // Valor negativo para mover hacia la izquierda (ajusta este valor según tus necesidades)
        transform.position = new Vector3(Personaje.transform.position.x + offsetX, initialCameraPosition.y, initialCameraPosition.z);
    }
}
