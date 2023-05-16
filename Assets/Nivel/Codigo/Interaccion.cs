using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public LayerMask mask;
    public GameObject Numero_1;
    public bool cerca;
    public bool Verdadero;

    private void Start()
    {
        mask = LayerMask.GetMask("Objetos");
        cerca = false;
    }

    private void Update()
    {
        cerca = Physics2D.OverlapCircle(transform.position, 1f, mask);

        if (cerca && Input.GetKeyDown(KeyCode.G))
        {
            Verdadero = true;
            Debug.Log("VERDADERO");
        }
 
    }
}
