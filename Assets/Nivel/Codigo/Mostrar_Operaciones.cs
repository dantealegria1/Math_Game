using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mostrar_Operaciones : MonoBehaviour
{
    public TextMeshProUGUI Operacioncita;
    public GameObject Numero_1;

    public List<Vector2> posiciones = new List<Vector2>(); // Lista para almacenar todas las posiciones

    //opciones de posicion
    public Vector2 posicion1 = new Vector2(0.38f, 1.35f);
    public Vector2 posicion2 = new Vector2(7.71f, -1.82f);
    public Vector2 posicion3 = new Vector2(17.21f, 2.22f);
    public Vector2 posicion4 = new Vector2(26.96f, 0.71f);
    public Vector2 posicion5 = new Vector2(33.09f, 3.99f);
    public Vector2 posicion6 = new Vector2(35.15f, 1.51f);
    public Vector2 posicion7 = new Vector2(35.05f, -2f);
    public Vector2 posicion8 = new Vector2(31f, -2f);
    public Vector2 posicion9 = new Vector2(10.38f, 1.65f);
    public Vector2 posicion10 = new Vector2(0.71f, -1.82f);

    // Start is called before the first frame update
    void Start()
    {
        // Agregar las posiciones a la lista
        posiciones.Add(posicion1);
        posiciones.Add(posicion2);
        posiciones.Add(posicion3);
        posiciones.Add(posicion4);
        posiciones.Add(posicion5);
        posiciones.Add(posicion6);
        posiciones.Add(posicion7);
        posiciones.Add(posicion8);
        posiciones.Add(posicion9);
        posiciones.Add(posicion10);

        // Generar un índice aleatorio
        int indiceAleatorio = Random.Range(0, posiciones.Count);

        // Obtener la posición aleatoria
        Vector2 posicionAleatoria = posiciones[indiceAleatorio];

 
        // Establecer la posición del objeto Numero_1
        Numero_1.transform.position = posicionAleatoria;

        // Generate random operands
        int Operando1 = Random.Range(1, 10);
        int Operando2 = Random.Range(1, 10);

        // Calculate the result
        int Resultado = Operando1 + Operando2;

        // Set the text of Operacioncita to display the random operands
        Operacioncita.text = Operando1.ToString() + " + " + Operando2.ToString() + " =";

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
