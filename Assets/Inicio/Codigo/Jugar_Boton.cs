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
        }else if(Nombre == "Nivel_1 - Normal")
        {
            PlayerPrefs.SetString(DificultadKey, "Normal");
            PlayerPrefs.Save();
            Debug.Log("normal");
        }else if(Nombre == "Nivel_1 - Dificil(1)")
        {
            PlayerPrefs.SetString(DificultadKey, "Dificil");
            PlayerPrefs.Save();
            Debug.Log("dificil");
        }
    }

    public void Salir()
    {
        Application.Quit(); 
        Debug.Log("Saliste");
    }
}
