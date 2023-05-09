using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource source { get { return GetComponent<AudioSource>(); } }
    public Button btn { get { return GetComponent<Button>(); } }
    public AudioClip clip;

    void Start()
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        btn.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        source.PlayOneShot(clip);
    }

}
