using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Interaccion_malos : MonoBehaviour
{
    public LayerMask mask;
    public GameObject Numero_2;
    public GameObject Numero_3;
    public GameObject Numero_4;
    public GameObject Numero_5;
    public bool cerca;
    public bool Verdadero_malo;
    public int vidas = 3;
    public TextMeshProUGUI Vidas;

    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Objetos_malo");
        cerca = false;
    }

    // Update is called once per frame
    void Update()
    {
        cerca = Physics2D.OverlapCircle(transform.position, 1f, mask);
        if (cerca && Input.GetKeyDown(KeyCode.G))
        {
            Verdadero_malo = true;
            Debug.Log("ERRORR");
            vidas = vidas - 1;
            Vidas.text = " x "+vidas.ToString();
        }
        if (vidas == 0)
        {
            SceneManager.LoadScene("Perdiste");
        }
    }
}
