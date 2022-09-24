using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControler : MonoBehaviour
{
    [SerializeField] private AudioClip[] audios;

    private AudioSource controlAudio;
    public static AudioControler instancia;

    private void Awake()
    {
        controlAudio = GetComponent<AudioSource>();
    }
    private void Start()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }

    public void seleccionado(int indice,float volumen)
    {
        
        controlAudio.PlayOneShot(audios[indice], volumen);
    }
}
