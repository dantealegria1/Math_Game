using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jugar_Boton : MonoBehaviour
{
    private const string DificultadKey = "Dificultad";

    public void  CambiarEscena(string Nombre)
    {
        SceneManager.LoadScene(Nombre);

        if (Nombre == "Nivel_1")
        {
            PlayerPrefs.SetString(DificultadKey, "Facil");
            PlayerPrefs.Save();
            Debug.Log("facil");
        }
    }

    public void Salir()
    {
        Application.Quit(); 
        Debug.Log("Saliste");
    }
}
