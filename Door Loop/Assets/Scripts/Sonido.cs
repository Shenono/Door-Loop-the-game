using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;
    private AudioSource controlAudio;

    private void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }
    public void Audio(int Indice, float Volume)
    {
        controlAudio.PlayOneShot(audios[Indice], Volume);
    }
}
