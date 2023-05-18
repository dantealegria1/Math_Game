using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leer_Nombre : MonoBehaviour
{
    private const string NombreKey = "Nombre";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetInputText(string text)
    {
        PlayerPrefs.SetString(NombreKey, text);
        PlayerPrefs.Save();
        Debug.Log("Nombre guardado: " + text);
    }
}
