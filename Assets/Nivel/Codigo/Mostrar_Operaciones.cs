using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mostrar_Operaciones : MonoBehaviour
{
    public TextMeshProUGUI Operacioncita;
    // Start is called before the first frame update
    void Start()
    {
        // Generate random operands
        int Operando1 = Random.Range(1, 10);
        int Operando2 = Random.Range(1, 10);

        // Calculate the result
        int Resultado = Operando1 + Operando2;

        // Set the text of Operacioncita to display the random operands
        Operacioncita.text = Operando1.ToString() + " + " + Operando2.ToString();
    }


    // Update is called once per frame
    void Update()
    {

    }
    void MostrarCosas()
    {
    }
}
