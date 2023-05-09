using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
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
        transform.position = new Vector3(Personaje.transform.position.x, initialCameraPosition.y, initialCameraPosition.z);
    }
}
