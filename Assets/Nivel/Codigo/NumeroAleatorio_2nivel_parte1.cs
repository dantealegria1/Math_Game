using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumeroAleatorio_2nivel_parte1 : MonoBehaviour
{
    public GameObject Numero_2; // Referencia al objeto
    public GameObject Numero_3;
    public GameObject Numero_4;
    public GameObject Numero_5;
    public GameObject Numero_1;

    public List<Vector2> posiciones = new List<Vector2>();
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


    public TextMeshProUGUI Ayuda;
    // Start is called before the first frame update
    void Start()
    {

        int Numero2, Numero3, Numero4, Numero5;
        int.TryParse(Ayuda.text, out int ayudaNumero);

        do
        {
            Numero2 = Random.Range(1, 20);
            Numero3 = Random.Range(1, 20);
            Numero4 = Random.Range(1, 20);
            Numero5 = Random.Range(1, 20);
        } while (Numero2 == ayudaNumero || Numero3 == ayudaNumero || Numero4 == ayudaNumero || Numero5 == ayudaNumero);


        SetSprite(Numero_2, Numero2);
        SetSprite(Numero_3, Numero3);
        SetSprite(Numero_4, Numero4);
        SetSprite(Numero_5, Numero5);

        posiciones.Add(posicion1);
        posiciones.Add(posicion2);
        posiciones.Add(posicion3);
        posiciones.Add(posicion4);
        posiciones.Add(posicion5);
        posiciones.Add(posicion6);
       
        posiciones.Add(posicion8);
        posiciones.Add(posicion9);
        posiciones.Add(posicion10);

        // Obtener la posición del objeto Numero_1
        Vector2 posicionNumero1 = Numero_1.transform.position;

        // Eliminar la posición de Numero_1 de la lista
        posiciones.Remove(posicionNumero1);


        RANDOM(Numero_2);
        RANDOM(Numero_3);
        RANDOM(Numero_4);
        RANDOM(Numero_5);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetSprite(GameObject numero, int value)
    {
        string spriteName = "Numero/" + value.ToString(); // Use the result as the sprite name
        Sprite nuevoSprite = Resources.Load<Sprite>(spriteName); // Load the sprite by name from Resources folder

        if (nuevoSprite != null)
        {
            SpriteRenderer spriteRenderer = numero.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = nuevoSprite;
        }
        else
        {
            Debug.LogError("Sprite not found: " + spriteName);
        }
    }

    private void RANDOM(GameObject Numero)
    {
        // Generar un índice aleatorio
        int indiceAleatorio = Random.Range(0, posiciones.Count);

        // Obtener la posición aleatoria
        Vector2 posicionAleatoria = posiciones[indiceAleatorio];

        // Eliminar la posición seleccionada de la lista
        posiciones.RemoveAt(indiceAleatorio);

        // Establecer la posición del objeto Numero_1
        Numero.transform.position = posicionAleatoria;

    }
}
