using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Interaccion : MonoBehaviour
{
    public LayerMask mask;
    public GameObject Numero_1;
    public bool cerca;
    public bool Verdadero;
    Vector2 referencia = new Vector2(41, -1);
    float radio = 2f;


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
        if (Verdadero && (Vector2.Distance(transform.position, referencia) <= radio) )
        {
            Debug.Log("NICE");
            SceneManager.LoadScene("Nivel_2");
        }
 
    }
}
