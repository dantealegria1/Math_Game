using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jugar_Boton : MonoBehaviour
{


  public void  CambiarEscena(string Nombre)
    {
        SceneManager.LoadScene(Nombre);
    }

    public void Salir()
    {
        Application.Quit(); 
        Debug.Log("Saliste");
    }
}
