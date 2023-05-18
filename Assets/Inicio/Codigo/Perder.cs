using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Perder : MonoBehaviour
{
    private const string NombreKey = "Nombre";
    private const string DificultadKey = "Dificultad";
    private const string HighScoreKey = "HighScore";

    public TextMeshProUGUI Nombre;
    public TextMeshProUGUI Puntos;
    public TextMeshProUGUI Dificultad;

    // Start is called before the first frame update
    void Start()
    {
        // Obtener los valores almacenados en PlayerPrefs
        string nombre = PlayerPrefs.GetString(NombreKey);
        int puntos = PlayerPrefs.GetInt(HighScoreKey);
        string dificultad = PlayerPrefs.GetString(DificultadKey);

        // Asignar los valores a los TextMeshProUGUI
        Nombre.text = "Nombre: " + nombre;
        Puntos.text = "Puntos: " + puntos.ToString();
        Dificultad.text = "Dificultad: " + dificultad;

        PlayerPrefs.SetInt(HighScoreKey, 0); // Restablecer highScore a 0
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
