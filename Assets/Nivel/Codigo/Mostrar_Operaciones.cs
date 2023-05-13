using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mostrar_Operaciones : MonoBehaviour
{
    public TextMeshProUGUI Operacioncita;
    public GameObject Numero_1; // Referencia al objeto que contiene el sprite a cambiar

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

        // Change the sprite of Numero_1 to the result
        string spriteName = "Numero/" + Resultado.ToString(); // Use the result as the sprite name
        Sprite nuevoSprite = Resources.Load<Sprite>(spriteName); // Load the sprite by name from Resources folder

        if (nuevoSprite != null)
        {
            SpriteRenderer spriteRenderer = Numero_1.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = nuevoSprite;
        }
        else
        {
            Debug.LogError("Sprite not found: " + spriteName);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
