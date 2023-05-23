using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mostrar_operaciones2 : MonoBehaviour
{
    public TextMeshProUGUI Operacioncita;
    public TextMeshProUGUI Ayuda;
    public GameObject Numero_1;

    public List<Vector2> posiciones = new List<Vector2>(); // Lista para almacenar todas las posiciones

    //opciones de posicion
    public Vector2 posicion1 = new Vector2(8.63f, 1.86f);
    public Vector2 posicion2 = new Vector2(21.75f, -1.82f);
    public Vector2 posicion3 = new Vector2(16.85f, 0.2f);
    public Vector2 posicion4 = new Vector2(25.06f, 1.63f);
    public Vector2 posicion5 = new Vector2(3.65f, 0.12f);
    public Vector2 posicion6 = new Vector2(36.46f, 4.27f);

    public Vector2 posicion8 = new Vector2(0.41f, 3.21f);
    public Vector2 posicion9 = new Vector2(6.45f, -2.49f);
    public Vector2 posicion10 = new Vector2(13.44f, 2.83f);




    // Start is called before the first frame update
    void Start()
    {
        Ayuda.gameObject.SetActive(false);
        // Agregar las posiciones a la lista
        posiciones.Add(posicion1);
        posiciones.Add(posicion2);
        posiciones.Add(posicion3);
        posiciones.Add(posicion4);
        posiciones.Add(posicion5);
        posiciones.Add(posicion6);
       
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
        int Resultado;
        if (Operando1 < Operando2)
        {
            Resultado = Operando1 + Operando2;
            Operacioncita.text = Operando1.ToString() + " + " + Operando2.ToString();
        }
        else
        {
            Resultado = Operando1 - Operando2;
            Operacioncita.text = Operando1.ToString() + " - " + Operando2.ToString();
        }
        // Calculate the result

        Ayuda.text = Resultado.ToString();

        // Set the text of Operacioncita to display the random operands




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
