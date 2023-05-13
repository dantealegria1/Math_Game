using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numeros_aleatorios : MonoBehaviour
{
    public GameObject Numero_2; // Referencia al objeto
    public GameObject Numero_3;
    public GameObject Numero_4;
    public GameObject Numero_5;

    // Start is called before the first frame update
    void Start()
    {
        int Numero2, Numero3, Numero4, Numero5;

        Numero2 = Random.Range(1, 20);
        Numero3 = Random.Range(1, 20);
        Numero4 = Random.Range(1, 20);
        Numero5 = Random.Range(1, 20);

        SetSprite(Numero_2, Numero2);
        SetSprite(Numero_3, Numero3);
        SetSprite(Numero_4, Numero4);
        SetSprite(Numero_5, Numero5);
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
}
