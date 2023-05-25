using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    private static Musica instance;
    private AudioSource audioSource;

    // Referencia al archivo de sonido que deseas reproducir
    public AudioClip soundClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound();
    }

    private void PlaySound()
    {
        // Configurar el AudioSource y reproducir el sonido en bucle
        audioSource.clip = soundClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
