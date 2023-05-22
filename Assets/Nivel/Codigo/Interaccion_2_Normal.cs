using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;

public class Interaccion_2_Normal : MonoBehaviour
{
    public LayerMask mask;
    public GameObject Numero_1;
    public bool cerca;
    public bool Verdadero;
    Vector2 referencia = new Vector2(41, -1);
    float radio = 2f;
    public TextMeshProUGUI tmp; // Referencia al objeto de texto
    public TextMeshProUGUI Puntaje; // Referencia al objeto de texto

    private const string HighScoreKey = "HighScore";
    private const string DificultadKey = "dificultad";

    private int highScore;


    private void Start()
    {

        highScore = PlayerPrefs.GetInt(HighScoreKey);
        mask = LayerMask.GetMask("Objetos");
        cerca = false;
        tmp.gameObject.SetActive(false);
        Puntaje.text = highScore.ToString();
    }

    private void Update()
    {
        cerca = Physics2D.OverlapCircle(transform.position, 1f, mask);

        if (cerca && Input.GetKeyDown(KeyCode.G))
        {
            Verdadero = true;
            Debug.Log("VERDADERO");
            tmp.gameObject.SetActive(true);
        }

        if (Verdadero && (Vector2.Distance(transform.position, referencia) <= radio))
        {
            highScore++;
            PlayerPrefs.SetInt(HighScoreKey, highScore);
            PlayerPrefs.Save();
            Debug.Log("NICE");


            SceneManager.LoadScene("Nivel_1-Normal");


        }
    }
}
